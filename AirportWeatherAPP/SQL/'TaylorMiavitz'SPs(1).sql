use AirportWeatherAPP
GO

--Update an New Email for a pre existing user.
create or alter proc spUserEmailUpdate
@UserID INT,
@NewEmail nvarchar(255)
AS
BEGIN
	UPDATE Users
SET 
	Email = @NewEmail
WHERE 
	UserID = @UserID;
END;
GO

/*
exec spUserEmailUpdate @UserID = 1, @NewEmail = 'usernewemail@hotmail.com';
GO
*/

