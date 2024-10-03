use AirportWeatherAPP
GO

-- Delete an observation in tables they appear in 
Create or alter proc spObservationDelete
@ObservationID INT
AS
BEGIN
	-- First, delete the related alerts
	delete from Alerts where ObservationID = @ObservationID
	-- Then, delete the observation itself
	delete from Observations where ObservationID = @ObservationID
END
GO

/*
-- Test deleting an observation in tables they appear in
Exec spObservationDelete 
	@ObservationID = 5
GO
*/
