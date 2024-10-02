USE AirportWeatherAPP
GO

--Delete a Org by OrgName
CREATE or ALTER PROC spWeatherDataOrgDelete
@OrgName NVARCHAR(255)
AS 
BEGIN
DELETE FROM WeatherDataOrg
WHERE OrgName = @OrgName
END
GO

/*
--Test: Deleting AccuWeather from the table 
EXEC spWeatherDataOrgDelete 'AccuWeather'
*/
