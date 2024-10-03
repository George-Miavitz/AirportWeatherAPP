use AirportWeatherAPP
GO

-- Add a new alert to the Alert table
create or alter proc spAlertAdd
@UserID INT
,@ObservationID INT
,@CommunicationText NVARCHAR(255)
AS
BEGIN
	Insert Into Alerts (UserID, ObservationID,CommunicationText)
	Values (@UserID, @ObservationID, @CommunicationText)
END
GO

/*
-- Test adding a new alert to the Alert table
exec spAlertAdd
	@UserID = 4
	, @ObservationID = 3
	, @CommunicationText = 'Rainy weather at 9:30 PM'
GO
*/