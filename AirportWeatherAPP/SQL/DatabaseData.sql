use AirportWeatherAPP
GO

INSERT INTO Users (UserName, Email, [Password])
VALUES
('Alice', 'alice@example.com', 'password123'),
('Bob', 'bob@example.com', 'securepass'),
('Charlie', 'charlie@example.com', 'mypassword'),
('Diana', 'diana@example.com', 'dianapass'),
('Eve', 'eve@example.com', 'evepassword');


INSERT INTO WeatherDataOrg (OrgName)
VALUES
('National Weather Service'),
('Weather Underground'),
('AccuWeather'),
('Weather Channel'),
('Local Weather Station');

INSERT INTO Observations (UserID, OrgID, Descriptor, [Timestamp], Temperature, WindSpeed, WindDirection, Visibility)
VALUES
(1, 1, 'Clear sky', '2024-09-30 14:30:00', 75.5, 5.2, 'NW', 10.0),
(2, 2, 'Partly cloudy', '2024-09-30 15:00:00', 73.0, 3.8, 'N', 9.5),
(3, 3, 'Rainy', '2024-09-30 15:30:00', 68.4, 7.1, 'NE', 5.0),
(4, 4, 'Sunny', '2024-09-30 16:00:00', 77.8, 4.5, 'W', 10.0),
(5, 5, 'Foggy', '2024-09-30 16:30:00', 65.2, 2.3, 'S', 2.0);


INSERT INTO Alerts (UserID, ObservationID, CommunicationText)
VALUES
(1, 1, 'Clear sky observed at 2:30 PM'),
(2, 2, 'Partly cloudy conditions at 3:00 PM'),
(3, 3, 'Rainy weather reported at 3:30 PM'),
(4, 4, 'Sunny weather at 4:00 PM'),
(5, 5, 'Foggy conditions at 4:30 PM');


INSERT INTO Feedback (UserID, [Text], [Timestamp])
VALUES
(1, 'Great app for weather updates!', '2024-09-30 17:00:00'),
(2, 'Very accurate weather data.', '2024-09-30 17:15:00'),
(3, 'User-friendly interface.', '2024-09-30 17:30:00'),
(4, 'Helpful alerts.', '2024-09-30 17:45:00'),
(5, 'Could use more features.', '2024-09-30 18:00:00');


GO