USE AirportWeatherAPP
GO

-- Add a new Weather Data Organization
CREATE or ALTER PROC spWeatherDataOrgAdd
    @OrgName NVARCHAR(255) 
-- Input parameter for the organization's name
AS
BEGIN
    INSERT INTO WeatherDataOrg (OrgName)
    VALUES (@OrgName)
END
GO

/*
-- Test: Adding a new Weather Data Organization
EXEC spWeatherDataOrgAdd
    @OrgName = 'New Weather Service'
GO
*/
