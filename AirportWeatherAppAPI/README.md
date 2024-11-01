# **Assignment 4**

## **Pages**

### Page 1 - Home Page
- Introduction to the application with a breif overview of features.
- Navigation links to other pages, welcome message, and description of what users can expect.

### Page 2 - User Page (Dynamic)
-  Enables Users to Access their account and see their information.
-  Dynamic Page: Uses UserEmailUpdate API to allow update their email. (Taylor Miavitz)

### Page 3 - Feedback Page (Dynamic)
-  Allows each user to leave feedback on the web application. Also, view other feedback items from other users.
-  Dynamic Page: Uses GetFeedbackByUserID to search by User's ID retrieving that users feedback items. (Taylor Miavitz)

### Page 4 - Alert Page (Dynamic)
-  Allows for admins or top level users to prompt a immediate notice for severe weather.
-  Dynamic Page: Uses ...

### Page 5 - Obeservation Page (Dynamic)
-  States visual and/or measured observations for Airports
-  Dynamic Page: Uses ...

### Page 6 - Search Page
-  Allows a User to search for a specific airport through a search bar.
-  Will Integrate an Airport API from an outside source.

### Page 7 - Resource Page
-  Lists contact information for users to report errors or troubleshooting solutions.

### Page 8 Admin Page
- Access for admins to be able to see protected information and be able to change permissions as needed.


## **API's**

### Taylor Miavitz
- Two API's
  - UserEmailUpdate.cs
  - GetFeedbackByUserID.cs
- Folders:
  - "TaylorSPRepositories"
    - Contains the services and interfaces for both API's
  - Both Controllers are located in "Controllers" folder
    - GetFeedbackByUserIDController.cs
    - UserEmailUpdateController.cs

### Diego Reyes
- Two API's:
  - Alert (Adds an alert)
  - Observation (Deletes an observation)
- Folders:
  - "DiegoSPRepositories"
    - Contains the service and interface for both API's 
  - Both controllers are in the "Controllers" folder
    - Called:
      - AlertController.cs
      - ObservationController.cs

### Phillip Waller
- ...
- ...

### Henry Shearer
- ObservationAddClass
- WeatherOrgAddClass