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
CREATE TABLE voters(
	vid int primary key identity,
	firstName varchar(30) not null,
	middleName varchar(30) not null,
	lastName varchar(30) not null,
	passcode text not null,
	birth date not null,
	phone int,
	idNo varchar(50) not null,
	idimage image not null
)
go

go
CREATE PROC AddVoters
@firstName varchar(30),
@middleName varchar(30),
@lastName varchar(30),
@password text,
@birth date,
@phone int,
@idNo varchar(50),
@idImage image,
@msg varchar(100) OUTPUT
as
begin
	DECLARE @vcount int;
	SELECT @vcount = COUNT(*) FROM voters WHERE idNo = @idNo;
	if (@vcount = 0) 
		if(NULLIF(@firstName, '') IS NOT NULL)
			if(NULLIF(@firstName, '') IS NOT NULL)
				if (NULLIF(@lastName, '') IS NOT NULL)
					if (NULLIF(@lastName, '') IS NOT NULL)
						if(NULLIF(@birth, '') IS NOT NULL)
							if (NULLIF(@phone, '') IS NOT NULL)
								if(NULLIF(@idNo, '') IS NOT NULL)
									if (NULLIF(CONVERT(varbinary(max),@idImage), '') IS NOT NULL)
										INSERT INTO voters VALUES (@firstName,@middleName,@lastName,@password,@birth,@phone,@idNo,@idimage)
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