use AirportWeatherAPP
GO

--Get Feedback by UserId
Create proc spFeedbackGetByUserID
	@UserID Int
AS
BEGIN 
	Select * FROM Feedback
	where UserID = @UserID
END;
GO

/*
exec spFeedbackGetByUserID @UserID = 3 
GO
*/