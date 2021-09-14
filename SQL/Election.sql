go
-- drop database Election
go

GO
CREATE DATABASE Election
GO

go
use Election
go


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
CREATE TABLE voters(
	vid int primary key identity,
	firstName varchar(30) not null,
	middleName varchar(30) not null,
	lastName varchar(30) not null,
	passcode varchar(max) not null,
	birth date not null,
	phone int,
	idNo varchar(50) not null,
	idimage image not null
)
go

go
CREATE TABLE superAdmin(
	id int primary key identity,
	username varchar(30) not null,
	passcode varchar(max) not null
)
go

go
CREATE PROC Admin_Signin
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
CREATE PROC Voter_Signin
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
CREATE PROC AddVoters
@firstName varchar(30),
@middleName varchar(30),
@lastName varchar(30),
@password varchar(max),
@birth date,
@phone int,
@idNo varchar(50),
@idImage image,
@msg varchar(100) OUTPUT
as
begin
	SELECT * FROM voters WHERE idNo = @idNo;
	if (@@ROWCOUNT = 0) 
		if(NULLIF(@firstName, '') IS NOT NULL)
			if(NULLIF(@firstName, '') IS NOT NULL)
				if (NULLIF(@lastName, '') IS NOT NULL)
					if (NULLIF(@lastName, '') IS NOT NULL)
						if(NULLIF(@birth, '') IS NOT NULL)
							if (NULLIF(@phone, '') IS NOT NULL)
								if(NULLIF(@idNo, '') IS NOT NULL)
									if (NULLIF(CONVERT(varbinary(max),@idImage), '') IS NOT NULL)
										INSERT INTO voters VALUES (@firstName,@middleName,@lastName,dbo.Encrypt(@password),@birth,@phone,@idNo,@idimage)
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
		SET @msg = 'Voter already added'
end
go



-- select * from voters where passcode = dbo.Decrypt('snowden')

-- INSERT INTO voters VALUES ('mikiyas','lemlemu','gebrewold',dbo.Encrypt('snowden'),'12-2-2019',0941398934,'123','image.jpg')