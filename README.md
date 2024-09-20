# _**Airport Weather Application**_

## **Project Overview**

- This application is designed to work as an internal search application for airports. It will be able to pull weather data from an API by using a search function. 
 The end user will be able to search for an airport and see its current weather conditions along with a prediction of future weather. In the current development, 
 we include four pages: Search, Index (Home page), Current Events/Alerts, and Resources. The home page is what the end user initially interacts with and will include
 links to the other pages after further development. Search includes a search box the end user can type an airport name into and click the “search” button. Current Events/Alerts 
 will contain current and predicted severe weather information. Resources will contain helpful hyperlinks and the ability to contact support for the application if needed.

## **Future Enhancements**

- An API will be used to connect airports to the search function. We are still trying to determine if the search function should be listed on the home page or separate for clarity 
 of its function. This is due to the other pages we would like to incorporate into the web application. Weather data will be referenced from METAR and TAF data which seems to be open-sourced.

## **Collective Findings**

- After researching other repositories and web applications that perform similar functions, we have found many resources implemented into other applications. 
 These are listed as such. METAR and TAF are often used when observing current and future airport weather. This is due to the instruments used around airports 
 to do the exact function we are trying to incorporate into the internal web application.


 ## **Individual Reseach and Contributions**



 ### **George “Taylor” Miavitz**

#### Competitive Analysis

##### Similar Website
-[National Weather Service - Morgantown Airport](https://forecast.weather.gov/data/obhistory/KMGW.html)

##### Investigate Website
- Very basic design.
- A bit overwhelming with information.
- Tables, Headings, and Button links.
- Has tabs like historical weather, education, search, about, etc...

##### Technical Inspection
- Very basic web application.
- No bootstrap for the styles; all seem to be manually styled.
- Picture placement and header row are manually styled.

##### Summary
-Looking at the National Weather Services website, I navigated to Morgantown's airport to see what I could find. This is related to our web application because it would be our web app's primary function. Upon inspection, it seems like the application does not contain a bootstrap, which I found surprising. Everything looks to be manually done, which may have been on purpose for single searched airports. It provides more information than visually appealing effects. This may be what they are trying to achieve.



#### Github Research

##### Explore Repos
[Aviation Weather Reports](https://github.com/BraedenKilburn/AviationWeatherReports/blob/master/README.md)

##### Analyze README
-Similar to the web application we are planning to develop. This repository is mainly JavaScript but aims to simplify the visually complicated formats that are present in most similar websites.

##### Summary
-The README summed the repository up nicely. It explained how most web applications are visually complicated and overloaded with information when it comes to Airport weather reporting. The owner of this repository used a home page, airport page, METAR data page, and TAF weather forecast to give live updates for weather and airports. I liked the simplicity of their design and how it worked.



#### Prototype Dev

##### `SearchPage.cshtml`
###### Search Bar
- Need to add API later but the button is set up and ready to connect data to it.
- Search bar loader: Visually represent a loading function upon search using JavaScript. Used W3Schools and a little bit of Copilot.
- Copilot search: “Help integrate bootstrap into a loading spinner on a search button in HTML using JavaScript”
  - (Note) This helped add bootstrap into my loading bar but I am not sure that our specific bootstrap allows that. We may need to amend our bootstrap to include my function.



#### Document Individual Contributions

##### Contributions
- Created all 4 current pages.
- Created repository.
- Added search bar to `SearchPage.cshtml`.
- Formatted Search button and loading spinner using bootstrap.
- Added Pages to Nav Bar on the home page.
- Added loading spinner using javascript to the search page on-click of the search button. This is hidden until the button is clicked. (Not sure why it isn’t completely functional yet but it is hidden)
- Transcribed README using markdown.



- 


### **Phillip Waller**

#### Competitive Analysis

##### Similar Website
[NAS Status - FAA](https://nasstatus.faa.gov)

##### Investigate Website
- This website lists the current airport closures throughout the U.S.
- Clicking on the “View Details” hyperlink attached to each closure shows departure and arrival runways.
- Below the airport closures are forecasted airport events with planned terminals and routes.

##### Technical Inspection
- An indication (via a `<noscript>` tag) that the use of JavaScript is necessary for the website is the first thing that sticks out to me.
- Interesting breakdown of each element of the airport closures.
- Classes are used for each element of the closures, and buttons are used to show and hide details.

##### Summary
This website is going to be a valuable resource in the development of my page of our app because I am assigned to create the “Current Events/Alerts” page. Further inspection into how the JavaScript brings the closure notifications onto the website will provide me with a better view of what my development may look like. I did not previously think to include forecasted events into the website, but it is an element that can be an addition later on in the project. I was familiar with more of the tags than I expected such as `<header>`, `<div>`, `<button>`, and `<h2>`. It seems like the most difficult part of my page will be working through all of the classes in JavaScript.



#### GitHub Research

##### Explore Repos
[AtmosWeather](https://github.com/atticuscornett/AtmosWeather/blob/main/README.md)

##### Analyze README
-This app seems to have a much broader scope than our project because much of the focus of their README is on cross capability. However, the development of their project is documented very well and has useful pieces to it.

##### Summary
-Their README was well organized. In the “Development” section, there is a link to their Notion page where they have every update that they have completed as well as updates they are working on. In this section of the README, they specify that HTML, CSS, JavaScript, and Java are used throughout their development. If I further inspect the method that this website uses to pull alerts into the website, I can use similar code on ours. Many of the tabs are .json which will prove to be useful in the development of our website as well.



#### Prototype Dev

##### Webpage
###### Current Events/Alerts Page



#### Document Individual Contributions

- Current Events/Alerts Page




