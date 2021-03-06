go
 drop database Election
go

GO
CREATE DATABASE Election
GO

go
use Election
go

go
CREATE LOGIN voter with password = 'secure'; 
CREATE USER voterUser for login voter;

CREATE LOGIN eadmin with password = 'election'; 
CREATE USER adminUser for login eadmin;

CREATE LOGIN viewer with password = 'views'; 
CREATE USER viewerUser for login viewer;

grant insert,update,delete,select on election to adminUser with grant option
grant insert,update,delete,select on parties to adminUser with grant option
grant insert,update,delete,select on regions to adminUser with grant option
grant insert,update,delete,select on station to adminUser with grant option
grant insert,update,delete,select on superAdmin to adminUser with grant option
grant insert,update,delete,select on votecount to adminUser with grant option
grant insert,update,delete,select on voters to adminUser with grant option

grant insert,select on votecount to voterUser with grant option

grant select on election to viewerUser with grant option
grant select on parties to viewerUser with grant option
grant select on regions to viewerUser with grant option
grant select on station to viewerUser with grant option
grant select on superAdmin to viewerUser with grant option
grant select on votecount to viewerUser with grant option
grant select on voters to viewerUser with grant option

go

/**************************************** Tabels *****************************************/

go
CREATE TABLE superAdmin (
	id int primary key identity,
	username varchar(30) not null,
	passcode varchar(max) not null
)
go

go
CREATE TABLE voters(
	vid int primary key identity,
	firstName varchar(30) not null,
	middleName varchar(30) not null,
	lastName varchar(30) not null,
	passcode varchar(max) not null,
	birth date not null,
	phone int not null,
	sid int not null,
	idNo varchar(50) not null unique,
	idimage image not null,
	vstatus int
)
go

go
CREATE TABLE regions (
	rid int primary key identity,
	rname varchar(100) not null unique,
	rpopulation bigint
)
go

go
CREATE TABLE parties (
	pid int primary key identity,
	pname varchar(100) not null,
	logo image,
	eid int
)
go

go
CREATE TABLE station (
	sid int primary key identity,
	sname varchar(100) not null unique,
	rid int not null,
	eid int
)
go

go
CREATE TABLE election (
	eid int primary key identity,
	ename varchar(100) not null,
	e_start date,
	e_end date,
)
go

go
CREATE TABLE votecount(
	vcid int primary key identity,
	vid int, -- voter id
	eid int, -- election id
	vpid int, -- party id
	timer datetime
)
go


ALTER TABLE parties
ADD CONSTRAINT FK_electionparties
FOREIGN KEY (eid) REFERENCES election(eid)

ALTER TABLE station
ADD CONSTRAINT FK_electionstation
FOREIGN KEY (eid) REFERENCES election(eid)

ALTER TABLE station
ADD CONSTRAINT FK_stationregion
FOREIGN KEY (rid) REFERENCES regions(rid)

ALTER TABLE votecount
ADD CONSTRAINT FK_VoteVoter
FOREIGN KEY (vid) REFERENCES voters(vid)

ALTER TABLE votecount
ADD CONSTRAINT FK_VotedElection
FOREIGN KEY (eid) REFERENCES election(eid)

ALTER TABLE votecount
ADD CONSTRAINT FK_VotedParty
FOREIGN KEY (vpid) REFERENCES parties(pid)

ALTER TABLE voters
ADD CONSTRAINT FK_VoterStation
FOREIGN KEY (sid) REFERENCES station(sid)

/****************************************** END *********************************************/


/**************************************** Functions *****************************************/

go
CREATE FUNCTION dbo.Encrypt(@str varchar(max))
RETURNS varchar(max)
AS BEGIN 
    DECLARE @res varchar(max)
    SET @res = ENCRYPTBYPASSPHRASE('SQL SERVER 2008 Pass',@str)
    RETURN (@res)
    END
go

go
ALTER FUNCTION dbo.GivenVoice(@eid int,@pid int)
RETURNS int
as
begin
	DECLARE @voice int
	SELECT @voice = COUNT(vc.vpid)
	FROM votecount as vc
	where vc.eid = @eid and vc.vpid = @pid
	GROUP BY vc.vcid
	return @voice;
end
go

go
CREATE FUNCTION dbo.Decrypt(@encrypt varchar(max))
RETURNS varchar(max)
AS
BEGIN 
    DECLARE @res varchar(max)
    SET @res = DECRYPTBYPASSPHRASE('SQL SERVER 2008 Pass',@encrypt)
    RETURN(@res)
END
go

go
CREATE FUNCTION dbo.GetElectionName(@eid int)
returns varchar(100)
as
begin
	DECLARE @name varchar(100)
	SELECT @name = ename from Election WHERE eid = @eid
	return @name
end
go

go
CREATE FUNCTION dbo.GetStationName(@sid int)
returns varchar(100)
as
begin
	DECLARE @name varchar(100)
	SELECT @name = sname FROM station
	return @name
end
go

/****************************************** END *********************************************/


/************************************ Stored Procedure **************************************/

go
CREATE PROC SP_Admin_Signin
@username varchar(30),
@password varchar(max)
as
begin
	SELECT * from superAdmin WHERE username = @username and dbo.Decrypt(passcode) = @password
	if @@ROWCOUNT != 0
		return 1; -- login success
	else
		return 0; -- login failed
end
go

go
CREATE PROC SP_Admin_Exist
@username varchar(30)
as
begin
	SELECT * from superAdmin WHERE username = @username
	if @@ROWCOUNT != 0
		return 1; -- Admin exist
	else
		return 0; -- Doesn't exist
end
go

go
CREATE PROC SP_AddAdmin
@username varchar(100),
@password varchar(100)
as
begin
	INSERT INTO superAdmin VALUES (@username,dbo.Encrypt(@password))
end
go

go
CREATE PROC SP_EditAdmin
@aid int,
@username varchar(100),
@password varchar(100)
as
begin
	UPDATE superAdmin SET username = @username WHERE id = @aid
end
go

go
CREATE PROC SP_RemoveAdmin
@aid int
as
begin
	DELETE FROM superAdmin WHERE id = @aid
end
go
/*---------------- Voters ---------------*/

go
CREATE PROC SP_Voter_Signin
@idNo varchar(50),
@password varchar(max)
as
begin
	SELECT * from voters WHERE idNo = @idNo and dbo.Decrypt(passcode) = @password
	if @@ROWCOUNT != 0 
		return 1; -- login success
	else 
		return 0; -- login failed
end
go
go
CREATE PROC SP_AddVoters
@firstName varchar(30),
@middleName varchar(30),
@lastName varchar(30),
@password varchar(max),
@birth date,
@phone int,
@idNo varchar(50),
@idImage image,
@sid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM voters WHERE idNo = @idNo;
	if (@@ROWCOUNT = 0)
	begin
	SELECT * FROM station WHERE sid = @sid;
		if (@@ROWCOUNT = 1)
			if(NULLIF(@firstName, '') IS NOT NULL)
				if(NULLIF(@middleName, '') IS NOT NULL)
					if (NULLIF(@lastName, '') IS NOT NULL)
						if (NULLIF(@password, '') IS NOT NULL)
							if(NULLIF(@birth, '') IS NOT NULL)
								if (NULLIF(@phone, '') IS NOT NULL)
									if(NULLIF(@idNo, '') IS NOT NULL)
										if (NULLIF(CONVERT(varbinary(max),@idImage), '') IS NOT NULL)
											if (NULLIF(@sid,'') IS NOT NULL)
												INSERT INTO voters VALUES (@firstName,@middleName,@lastName,dbo.Encrypt(@password),@birth,@phone,@sid,@idNo,@idimage,1)
											else
												SET @msg = 'Station is required'
										else
											SET @msg = 'ID image is required'
									else
										SET @msg = 'ID number is required'
								else
									SET @msg = 'Phone number is required'
							else
								SET @msg = 'birth date is required'
						else
							SET @msg = 'password is required'
					else
						SET @msg = 'last name is required'
				else
					SET @msg = 'middle name is required'
			else
				SET @msg = 'first name is required'
		else
			SET @msg = 'Unknown Station'
	end
	else 
	begin
		SET @msg = 'Voter already added'
	end
end
go
go
CREATE PROC SP_EditVoters
@vid int,
@firstName varchar(30),
@middleName varchar(30),
@lastName varchar(30),
@birth date,
@phone int,
@idNo varchar(50),
@idImage image,
@sid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM voters WHERE idNo = @idNo and vid != @vid;
	if (@@ROWCOUNT = 0)
	begin
	SELECT * FROM station WHERE sid = @sid;
		if (@@ROWCOUNT = 1)
			if(NULLIF(@firstName, '') IS NOT NULL)
				if(NULLIF(@middleName, '') IS NOT NULL)
					if (NULLIF(@lastName, '') IS NOT NULL)
						if(NULLIF(@birth, '') IS NOT NULL)
							if (NULLIF(@phone, '') IS NOT NULL)
								if(NULLIF(@idNo, '') IS NOT NULL)
									if (NULLIF(CONVERT(varbinary(max),@idImage), '') IS NOT NULL)
										if (NULLIF(@sid,'') IS NOT NULL)
											UPDATE voters SET firstName = @firstName,middleName = @middleName,lastName = @lastName,birth = @birth,phone = @phone,sid = @sid,idNo = @idNo,idimage = @idimage WHERE vid = @vid
										else
											SET @msg = 'Station is required'
									else
										SET @msg = 'ID image is required'
								else
									SET @msg = 'ID number is required'
							else
								SET @msg = 'Phone number is required'
						else
							SET @msg = 'birth date is required'
					else
						SET @msg = 'last name is required'
				else
					SET @msg = 'middle name is required'
			else
				SET @msg = 'first name is required'
		else
			SET @msg = 'Unknown Station'
	end
	else 
	begin
		SET @msg = 'Voter already added'
	end
end
go
go
CREATE PROC SP_RemoveVoters
@vid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM voters WHERE @vid = @vid;
	if (@@ROWCOUNT = 1)
	begin
		DELETE FROM voters WHERE vid = @vid								
	end
	else 
	begin
		SET @msg = 'Unknown Voter'
	end
end
go

go
CREATE PROC SP_GetVoters
@id varchar(100)
as
begin
	SELECT * from voters WHERE idNo = @id
end
go
go
CREATE PROC SP_CountVoters
@size int OUTPUT
as
begin
	SELECT @size = count(*) FROM voters
end
go
/*---------------- End Voters ---------------*/


/*---------------- Party ---------------*/

go
CREATE PROC SP_AddParty
@pname varchar(100),
@logo image,
@eid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM parties WHERE pname = @pname and eid = @eid;
	if (@@ROWCOUNT = 0) 
		if(NULLIF(@pname, '') IS NOT NULL)
			if(NULLIF(@eid, '') IS NOT NULL)
				if (NULLIF(CONVERT(varbinary(max),@logo), '') IS NOT NULL)
						INSERT INTO parties VALUES (@pname,@logo,@eid)
				else
					SET @msg = 'Party logo is required'
			else
				SET @msg = 'Election is required'
		else
			SET @msg = 'Party name is required'	
	else
		SET @msg = 'Party name already exists'
end
go

go
CREATE PROC SP_EditParty
@pid int,
@pname varchar(100),
@logo image,
@eid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM parties WHERE pname = @pname and pid != @pid and eid = @eid;
	if (@@ROWCOUNT = 0) 
		if(NULLIF(@pname, '') IS NOT NULL)
			if(NULLIF(@eid, '') IS NOT NULL)
				if (NULLIF(CONVERT(varbinary(max),@logo), '') IS NOT NULL)
						UPDATE parties SET pname = @pname,logo = @logo,eid=@eid WHERE pid = @pid
				else
					SET @msg = 'Party logo is required'
			else
				SET @msg = 'Election is required'
		else
			SET @msg = 'Party name is required'	
	else
		SET @msg = 'Party name already exists'
end
go

go
CREATE PROC SP_RemoveParty
@pid int,
@msg varchar(100) output
as
begin
	SELECT * FROM parties WHERE pid = @pid;
	if (@@ROWCOUNT = 1)
		DELETE FROM parties WHERE pid = @pid
	else
		SET @msg = 'Unknown Party'
end
go

go
CREATE PROC SP_GetParty
@pname varchar(100),
@msg varchar(100) OUTPUT
as
begin
	
	if(NULLIF(@pname, '') IS NOT NULL)
	begin
		SELECT * FROM parties where pname = @pname
		if @@ROWCOUNT = 0
			SET @msg = 'Unknown Party'
	end
	else 
		SET @msg = 'Party Name is required'
end
go
go
CREATE PROC SP_GetParties
as
begin
	SELECT * FROM parties;
end
go
go
CREATE PROC SP_GetPartiesByEID
@eid int,
@msg varchar(100) OUTPUT
as
begin
	
	if(NULLIF(@eid, '') IS NOT NULL)
	begin
			SELECT * FROM parties WHERE eid = @eid;
	end
	else 
		SET @msg = 'Election id is required'
end
go

go
CREATE PROC SP_CountParties
@size int OUTPUT
as
begin
	SELECT @size = count(*) FROM parties

end
go
/*---------------- Party end ---------------*/

/*---------------- Region ---------------*/
go
CREATE PROC SP_AddRegion
@rname varchar(100),
@population int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM regions WHERE rname = @rname;
	if (@@ROWCOUNT = 0) 
		if(NULLIF(@rname, '') IS NOT NULL)
			if (NULLIF(@population, '') IS NOT NULL)
					INSERT INTO regions VALUES (@rname,@population)
			else
				SET @msg = 'Population number is required'
		else
			SET @msg = 'Region name is required'	
	else
		SET @msg = 'Region name already exists'
end
go

go
CREATE PROC SP_EditRegion
@rid int,
@rname varchar(100),
@population int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM regions WHERE rname = @rname and rid != @rid;
	if (@@ROWCOUNT = 0) 
		if(NULLIF(@rname, '') IS NOT NULL)
			if (NULLIF(@population, '') IS NOT NULL)
					UPDATE regions SET rname = @rname,rpopulation = @population WHERE rid = @rid
			else
				SET @msg = 'Population number is required'
		else
			SET @msg = 'Region name is required'	
	else
		SET @msg = 'Region name already exists'
end
go

go
CREATE PROC SP_RemoveRegion
@rid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM regions WHERE rid = @rid;
	if (@@ROWCOUNT = 1) 
		DELETE FROM regions WHERE rid = @rid	
	else
		SET @msg = 'Unknown Region'
end
go

go
CREATE PROC SP_GetRegion
@rname varchar(100),
@msg varchar(100) OUTPUT
as
begin
	if(NULLIF(@rname, '') IS NOT NULL)
	begin
		SELECT * FROM regions where rname = @rname
		if @@ROWCOUNT = 0
			SET @msg = 'Unknown Region'
	end
	else 
		SET @msg = 'Region Name is required'
end
go

go
CREATE PROC SP_GetDetails
@rid int,
@eid int,
@msg varchar(100) OUTPUT
as
begin
	if(NULLIF(@eid, '') IS NOT NULL)
	begin
		if(NULLIF(@rid, '') IS NOT NULL)
		begin
			SELECT r.rid as id,r.rname as name,r.rpopulation as population,COUNT(DISTINCT s.sid) as stations,COUNT(DISTINCT v.vid) as voters,COUNT(DISTINCT vc.vcid) as voted FROM regions as r 
			left JOIN station as s on r.rid = s.rid and s.eid = @eid
			left JOIN voters as v on v.sid = s.sid
			left JOIN votecount as vc on vc.vid = v.vid
			where r.rid = @rid
			GROUP BY r.rid,r.rname,r.rpopulation
		end
		else 
			SET @msg = 'Region id is required'
	end
		else 
			SET @msg = 'Election id is required'
end
go

go
CREATE PROC SP_GETRegions
as
begin
	SELECT * FROM regions;
end
go

go
CREATE PROC SP_CountRegions
@size int OUTPUT
as
begin
	SELECT @size = count(*) FROM regions

end
go

go
CREATE PROC SP_Population
@size int OUTPUT
as
begin
	SELECT @size = sum(rpopulation) FROM regions
end
go
/*-------------- Region End-------------*/

/*---------------- Station ---------------*/

go
CREATE PROC SP_AddStation
@sname varchar(100),
@rid int,
@eid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM station WHERE sname = @sname and eid = @eid;
	if (@@ROWCOUNT = 0) 
	begin
		SELECT * FROM regions WHERE rid = @rid;
		if(@@ROWCOUNT = 1)
			if(NULLIF(@sname, '') IS NOT NULL)
				if(NULLIF(@eid, '') IS NOT NULL)
					if (NULLIF(@rid, '') IS NOT NULL)
							INSERT INTO station VALUES (@sname,@rid,@eid)
					else
						SET @msg = 'Region is required'
				else
					SET @msg = 'Election is required'
			else
				SET @msg = 'Station name is required'
		else
			SET @msg = 'Unknown Region'
	end
	else begin
		SET @msg = 'Station name already exists'
		end
end
go

go
CREATE PROC SP_EditStation
@sid int,
@sname varchar(100),
@rid int,
@eid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM station WHERE sname = @sname and sid != @sid and eid = @eid;
	if (@@ROWCOUNT = 0) 
	begin
		SELECT * FROM regions WHERE rid = @rid;
		if(@@ROWCOUNT = 1)
			if(NULLIF(@sname, '') IS NOT NULL)
				if(NULLIF(@eid, '') IS NOT NULL)
					if (NULLIF(@rid, '') IS NOT NULL)
							UPDATE station SET sname = @sname,rid = @rid,eid = @eid WHERE sid = @sid
					else
						SET @msg = 'Region is required'
				else
					SET @msg = 'Election is required'
			else
				SET @msg = 'Station name is required'
		else
			SET @msg = 'Unknown Region'
	end
	else begin
		SET @msg = 'Station name already exist'
		end
end
go

go
CREATE PROC SP_RemoveStation
@sid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM station WHERE sid = @sid;
	if (@@ROWCOUNT = 1) 
	begin
		DELETE FROM station WHERE sid = @sid	
	end
	else begin
		SET @msg = 'Unknown station' +CAST(@sid as varchar(100))
		end
end
go

go
CREATE PROC SP_GetStations
as
begin
	SELECT s.sid as id,s.sname as station,r.rname as region FROM station as s left join regions as r on s.rid = r.rid;
end
go

go
CREATE PROC SP_GetStation
@sname varchar(100),
@msg varchar(100) OUTPUT
as
begin
	
	if(NULLIF(@sname, '') IS NOT NULL)
	begin
		SELECT * FROM station where sname = @sname
		if @@ROWCOUNT = 0
			SET @msg = 'Unknown Station'
	end
	else 
		SET @msg = 'Station Name is required'
end
go

go
CREATE PROC SP_GetStationByID
@sid int,
@msg varchar(100) OUTPUT
as
begin
	
	if(NULLIF(@sid, '') IS NOT NULL)
	begin
		SELECT * FROM station where sid = @sid
		if @@ROWCOUNT = 0
			SET @msg = 'Unknown Station'
	end
	else 
		SET @msg = 'Station id is required'
end
go

go
CREATE PROC SP_CountStations
@size int OUTPUT
as
begin
	SELECT @size = count(*) FROM station
end
go
/*-------------- Station End-------------*/

/*---------------- Election ---------------*/
go
CREATE PROC SP_AddElection 
@name varchar(100),
@start date,
@end date,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM election WHERE ename = @name;
	if (@@ROWCOUNT = 0) 
	begin
		if(NULLIF(@name, '') IS NOT NULL)
			if (NULLIF(@start, '') IS NOT NULL)
				if (NULLIF(@end, '') IS NOT NULL)
					INSERT INTO election VALUES (@name,@start,@end)
				else
					SET @msg = 'Ending date is required'
			else
				SET @msg = 'Starting is required'
		else
			SET @msg = 'Election name is required'
	end
	else begin
		SET @msg = 'Election name already exists'
		end
end
go

go
CREATE PROC SP_EditElection 
@eid int,
@name varchar(100),
@start date,
@end date,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM election WHERE ename = @name and eid != @eid;
	if (@@ROWCOUNT = 0) 
		if(NULLIF(@eid, '') IS NOT NULL)
			if(NULLIF(@name, '') IS NOT NULL)
				if (NULLIF(@start, '') IS NOT NULL)
					if (NULLIF(@end, '') IS NOT NULL)
						UPDATE election SET ename = @name,e_start = @start,e_end = @end WHERE eid = @eid
					else
						SET @msg = 'Ending date is required'
				else
					SET @msg = 'Starting is required'
			else
				SET @msg = 'Election name is required'
		else
			SET @msg = 'Election id is required'
	else 
		SET @msg = 'Election name already exists'
end
go

go
CREATE PROC SP_RemoveElection 
@eid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM election WHERE eid = @eid;
	if (@@ROWCOUNT = 1)
		DELETE FROM election WHERE eid = @eid
	else 
		SET @msg = 'Unknown Election'
end
go

go
CREATE PROC SP_GetElections
as
begin
	SELECT * from election
end
go

go
CREATE PROC SP_GetElection
@ename varchar(100),
@msg varchar(100) OUTPUT
as
begin
	if(NULLIF(@ename, '') IS NOT NULL)
	begin
		SELECT * FROM election where ename = @ename
		if @@ROWCOUNT = 0
			SET @msg = 'Unknown Election'
	end
	else 
		SET @msg = 'Election Name is required'
end
go

/*-------------- Election End-------------*/

go
CREATE PROC SP_VOTE
@vid int,
@eid int,
@pid int,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM votecount WHERE vid = @vid and eid = @eid;
	if (@@ROWCOUNT = 0)
		if(NULLIF(@vid, '') IS NOT NULL)
			if (NULLIF(@eid, '') IS NOT NULL)
				if (NULLIF(@pid, '') IS NOT NULL)
					INSERT INTO votecount VALUES (@vid,@eid,@pid,CURRENT_TIMESTAMP)
				else
					SET @msg = 'Please choose a party'
			else
				SET @msg = 'Something is wrong try again' -- election id not received
		else
			SET @msg = 'Voter is empty'
	else
	 SET @msg = 'Can not vote twice'
end
go

go
CREATE PROC SP_RemoveVote
@vcid int,
@msg varchar(100) OUTPUT
as
begin
	if (NULLIF(@vcid, '') IS NOT NULL)
		DELETE FROM votecount WHERE vcid = @vcid
	else
		SET @msg = 'please insert the vote count id'
end
go

go
CREATE PROC SP_CheckVoter
@vid int
as
begin
	if(NULLIF(@vid, '') IS NOT NULL) begin
		DECLARE @sid int,@eid int
		SELECT @sid = sid FROM voters WHERE vid = @vid;
		SELECT @eid = eid FROM station WHERE sid = @sid;
		SELECT * FROM votecount WHERE vid = @vid and eid = @eid;
		if (@@ROWCOUNT = 0)
			return 1;
		else
			return 0;
	end
	else
	 return 0;
end
go

go
ALTER PROC SP_LeadBoard
@eid int,
@msg varchar(100) OUTPUT
as
begin
	select pname as Name,logo,CASE when dbo.GivenVoice(eid,pid) IS NULL then 0 else dbo.GivenVoice(eid,pid) end as Voice from parties where eid = @eid order by dbo.GivenVoice(eid,pid) DESC
end
go

go
CREATE PROC SP_highest
@eid int,
@msg varchar(100) OUTPUT
AS
BEGIN
	SELECT top 1 vpid FROM votecount WHERE eid = 1  GROUP BY vpid ORDER BY COUNT(vcid)
END
go



/***************************************** TRIGGER *******************************************/

-- disable trigger [prevent region insertion]

go
CREATE TRIGGER [prevent region insertion]
ON regions
INSTEAD OF INSERT
AS
begin
	RAISERROR('You can not insert region', 16, 2);
end
go

go
CREATE TRIGGER [prevent region removal]
ON regions
INSTEAD OF DELETE
AS
begin
	RAISERROR('You can not remove a region', 16, 2);
end
go

go
CREATE TRIGGER [prevent region name updated]
ON regions
AFTER UPDATE
AS
begin
	DECLARE @old_name varchar(100)
	DECLARE @new_name varchar(100)
	
	update regions set rname = 'sure' where rid = 1

	SELECT @old_name = rname FROM deleted
	SELECT @new_name = rname FROM inserted
	if (@old_name != @new_name)
	begin
		ROLLBACK
		RAISERROR('Region name could not be updated', 16, 2);
	end
end
go

go
CREATE TRIGGER [prevent invalid EDate]
ON election
AFTER INSERT,UPDATE
AS
begin
	DECLARE @start date
	DECLARE @end date
	
	SELECT @start = e_start,@end = e_end FROM inserted

	IF (@start > @end) 
	begin 
		ROLLBACK
		RAISERROR('The starting date can not be less than the ending date', 16, 2);
	end
end
go

go
create TRIGGER [prevent invalid vote]
ON votecount
AFTER INSERT
AS
begin
	DECLARE @eid int
	DECLARE @start date
	DECLARE @end date
	
	SELECT @eid = eid FROM inserted
	SELECT @start = e_start,@end = e_end from election where eid = @eid
	if (@start < GETDATE())
	begin
		ROLLBACK
		RAISERROR('The election have not started yet', 16, 2);
	end
	else if (@end > GETDATE()) 
	begin 
		ROLLBACK
		RAISERROR('The election has ended', 16, 2);
	end
end
go


INSERT INTO regions VALUES ('Addis Ababa',3273000),
						   ('Afar',1723000),
						   ('Amhara',20401000),
						   ('Benishangul-Gumuz',1005000),
						   ('Dire Dawa',440000),
						   ('Gambela',409000),
						   ('Harari',232000),
						   ('Oromia',33692000),
						   ('Sidama',3200000),
						   ('Somali',5453000),
						   ('SNNP',11426000),
						   ('Tigray',5056000)
INSERT INTO superAdmin VALUES ('Mikiyas',dbo.Encrypt('12345678'))



BACKUP DATABASE Election
TO DISK = 'C:\Users\mikiy\Desktop\db_backup\myDB.bak'

BACKUP DATABASE Election
TO DISK = 'C:\Users\mikiy\Desktop\db_backup\myDB.bak'
WITH DIFFERENTIAL



/****************************************** END *********************************************/
/*
select * from parties
select * from voters where dbo.Decrypt(passcode) = 'snowden'
SELECT * FROM regions

UPDATE election set ename = 'Election 1',e_start = '9-22-2021' WHERE eid = 1
INSERT INTO election VALUES ('Election 1','9-23-2021','9-29-2021')
INSERT INTO voters VALUES ('mikiyas','lemlemu','gebrewold',dbo.Encrypt('123'),'12-2-2019',0941398934,1,'100001','image.jpg',1)
INSERT INTO voters VALUES ('Surafel','Zeleke','Ayalew',dbo.Encrypt('123'),'7-9-2000',0941398934,1,'100002','images.jpg',1)
INSERT INTO station VALUES ('AAL001',1,1)
INSERT INTO station VALUES ('AAL002',1,2)
select * from voters
select * from station
select * from election 
select * from votecount
select * from parties





update voters set vid = 10 where vid = 3
delete from voters where vid in (1,2)*/


