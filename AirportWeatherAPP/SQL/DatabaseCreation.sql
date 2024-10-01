Create database AirportWeatherAPP
GO

use AirportWeatherAPP
Go

-- User table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    [Password] NVARCHAR(255) NOT NULL,
);

-- WeatherDataOrg Table
CREATE TABLE WeatherDataOrg (
    OrgID INT PRIMARY KEY IDENTITY(1,1),
    OrgName NVARCHAR(255) NOT NULL
);

-- Observation Table
CREATE TABLE Observations (
    ObservationID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
	OrgID INT NOT NULL FOREIGN KEY REFERENCES WeatherDataOrg(OrgID),
    Descriptor NVARCHAR(100),
    [Timestamp] DATETIME NOT NULL,
    Temperature DECIMAL(5,2),
    WindSpeed DECIMAL(5,2),
    WindDirection NVARCHAR(50),
    Visibility DECIMAL(5,2)
);

-- Alert Table
CREATE TABLE Alerts (
    AlertID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    ObservationID INT NOT NULL FOREIGN KEY REFERENCES Observations(ObservationID),
    CommunicationText NVARCHAR(255) 
);

-- Feedback Table
CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    [Text] NVARCHAR(MAX),
    [Timestamp] DATETIME NOT NULL
);