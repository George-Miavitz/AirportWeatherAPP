# _**Assignment 3**_

## **Company Statement**
	We’re thrilled to introduce our new web application that will transform airport weather data management. 
	This platform combines real-time weather updates, historical weather data, prompt severe weather alerts, 
	and an opportunity for us to see your feedback. By using technology, we ensure our clients get accurate 
	and timely weather information, boosting efficiency and safety at airports.


## **MIST 353 Airport Weather APP Stored Procedures**

**spUserAdd**\
Action: Add a new user to the User Table.\
Parameters:\
	- @UserId INT\
	- @Username NVARCHAR(255)\
	- @Email NVARCHAR(255)\
	- @Password NVARCHAR(255)
	

**spWeatherDataOrgAdd**\
Action: Add a new Organization to Weather Data Organization\
Parameters:\
	- @OrgName NVARCHAR(255)


**spObservationAdd**\
Action: Add a new observation to the observation table.\
Parameters:\
	- @UserID INT\
	- @OrgID INT\
	- @Descriptor NVARCHAR(255)\
	- @Timestamp DATETIME\
	- @Temperature Decimal(5,2)\
	- @WindDirection NVARCHAR(50)\
	- @Visibility Decimal(5,2)


**spAlertAdd**\
Action: Add a new alert to the alert table\
Parameters:\
	- @UserID INT\
	- @ObservationID INT\
	- @CommunicationText NVARCHAR(255)



**spFeedbackAdd**\
Action: Add new feedback to the feedback table\
Parameters:\
	- @UserID INT\
	- @Text NVARCHAR(255)\
	- @Timestamp DATETIME



**spUserEmailUpdate**\
Action: Update an individual user’s email address\
Parameters: \
	- @UserID INT\
	- @NewEmail NVARCHAR(255)



**spObservationDelete**\
Action: Delete a single observation\
Parameters:\
	- @Observation INT



**spFeedbackGetByUserID**\
Action: Retrieve Feedback based on a users ID\
Parameters: \
	- @UserID INT


**spWeatherDataOrg**\
Action: Add an organtization name to the table\
Parameters:\
	- @OrgName NVARCHAR(255) 


**spObservationAdd**\
Action: An user can add an observation they have to the table or from other data\
Parameters:\
  @UserID INT,               
    @OrgID INT,                
    @Descriptor NVARCHAR(100), 
    @Timestamp DATETIME,       
    @Temperature DECIMAL(5,2), 
    @WindSpeed DECIMAL(5,2),   
    @WindDirection NVARCHAR(50),
    @Visibility DECIMAL(5,2)   


## **References and Notes**

### Taylor Miavitz

	- W3 Schools “Update” category for my stored procedure
	- Copilot to fill in mock database data.  Prompt: “Provide Data For These Tables ...”
	- Note: Three database tables are plural ex. “Observations”. 
	We did not find this out until after creating our procedures and we acknowledge
	that they need to be singular and will update this if needed later on.

### Diego Reyes

	- Class notes on adding a new alert to the Alert table
	- Class notes on deleting an observation from all tables they appear in


### Phillip Waller

	- Class notes on adding a vehicle and deleting an org for my two stored procedures

### Henery Shearer

	- Used class notes to help adding data to both the WeatherData table and Observation table.









