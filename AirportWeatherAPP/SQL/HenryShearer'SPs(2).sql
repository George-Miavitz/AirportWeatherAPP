USE AirportWeatherAPP
GO

-- For adding a new Observation to the Observations Table
CREATE or ALTER PROC spObservationAdd
-- All the values for the observation table
    @UserID INT,               
    @OrgID INT,                
    @Descriptor NVARCHAR(100), 
    @Timestamp DATETIME,       
    @Temperature DECIMAL(5,2), 
    @WindSpeed DECIMAL(5,2),   
    @WindDirection NVARCHAR(50),
    @Visibility DECIMAL(5,2)   
AS
BEGIN
    INSERT INTO Observations (UserID, OrgID, Descriptor, [Timestamp], Temperature, WindSpeed, WindDirection, Visibility)
    VALUES (@UserID, @OrgID, @Descriptor, @Timestamp, @Temperature, @WindSpeed, @WindDirection, @Visibility)
END
GO

/*
-- Test: Adding a new observation to the table
EXEC spObservationAdd
    @UserID = 1,
    @OrgID = 1,
    @Descriptor = 'Clear sky',
    @Timestamp = '2024-09-30 14:30:00',
    @Temperature = 94.2,
    @WindSpeed = 1.2,
    @WindDirection = 'NW',
    @Visibility = 10.0
GO
*/
