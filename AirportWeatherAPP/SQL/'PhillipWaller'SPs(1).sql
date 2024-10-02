USE AirportWeatherAPP
GO

--Add a New User to the User Table
CREATE or ALTER PROC spUserAdd
@Username NVARCHAR(255)
,@Email NVARCHAR(255)
,@Password NVARCHAR(255)
AS
BEGIN
INSERT INTO Users(Username, Email, [Password])
VALUES(@Username, @Email, @Password)
END
GO

/*
--Test: Adding myself as a User
EXEC spUserAdd
@Username = 'Phil'
,@Email = 'phillipw@gmail.com'
,@Password = '1234Phil'
GO
*/
