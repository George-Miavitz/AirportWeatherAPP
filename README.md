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
- This website is going to be a valuable resource in the development of my page of our app because I am assigned to create the “Current Events/Alerts” page. Further inspection into how the JavaScript brings the closure notifications onto the website will provide me with a better view of what my development may look like. I did not previously think to include forecasted events into the website, but it is an element that can be an addition later on in the project. I was familiar with more of the tags than I expected such as `<header>`, `<div>`, `<button>`, and `<h2>`. It seems like the most difficult part of my page will be working through all of the classes in JavaScript.



#### GitHub Research

##### Explore Repos
[AtmosWeather](https://github.com/atticuscornett/AtmosWeather/blob/main/README.md)

##### Analyze README
- This app seems to have a much broader scope than our project because much of the focus of their README is on cross capability. However, the development of their project is documented very well and has useful pieces to it.

##### Summary
- Their README was well organized. In the “Development” section, there is a link to their Notion page where they have every update that they have completed as well as updates they are working on. In this section of the README, they specify that HTML, CSS, JavaScript, and Java are used throughout their development. If I further inspect the method that this website uses to pull alerts into the website, I can use similar code on ours. Many of the tabs are .json which will prove to be useful in the development of our website as well.



#### Prototype Dev

##### `AlertPage.cshtml`
###### Current Events/Alerts Page



#### Document Individual Contributions

- Current Events/Alerts Page






### **Diego Reyes**

#### Competitive Analysis

##### Similar Website
[US Airnet - Airport Weather](https://www.usairnet.com/cgi-bin/launch/code.cgi?Submit=Go&sta=KVBT&state=AR 
)

##### Investigate Website
- This website has a variety of different meteorological measurements for airports in every state of the United States.
- You can see the weather data by searching by region or by specific ICAO airport code to see the meteorological data for that airport/region.
- It only displays current weather data and not forecasting data.
- It provides various maps relating to the specific meteorological measurement you have selected.

##### Technical Inspection
- Seems to be a pretty simple website/web application as it does not seem to have a bootstrap and all the styling is done manually through various styling tags.
- They use many buttons (JavaScript) and hide them and show them depending on user interactions with them.
- Overall it seems to be pretty simple in the sense that they are using simple tags (we have gone over them in class) and doing the styling manually.

##### Summary
- Upon investigating the website and using it as a user, I believe this website is pretty similar to what we want to create, which means it is a valuable resource for our group to leverage to have an idea of what to do but also where we could focus on more. This website is especially useful to our group as from inspecting it I have seen it is a rather simple website that uses basic tags to style and essentially build their entire application. This will help the group get a better handle and understanding of the basics of creating our own airport weather data web application.



#### GitHub Research

##### Explore Repos
[Airport Weather](https://github.com/parkersiu/airport-weather 
)

##### Analyze README
- The README is well organized but does not go into much detail about the specifics of the code. They tell us it is an HTML, CSS, and JavaScript application for pilots who want to view airport weather, which is similar to the app we are trying to build. They highlight the technologies used as well as all the features the app has for users to interact with. They provide a live demo which is great to be able to visualize their application and for me it has allowed me to understand their code a lot better.

##### Summary
- Overall this repo will be a great help to our group as it is well organized and is similar to the web app we are trying to build throughout the semester. There are folders for each type of coding language they used which helped me understand how the app worked and how the languages were working together to create the app. This repo will be a good way to understand how to implement JavaScript into our own web app and bootstrap as well.



#### Prototype Dev

##### Webpage
###### Home Page `Index.cshtml`



#### Document Individual Contributions

##### Webpage
- Home Page (index page)
- Created a slide show of 3 images
- Added a mission statement under the slide show
- Used HTML, CSS, and JavaScript
- Used the bootstrap

##### Bootstrap
- Implemented the **Flatly** theme bootstrap

##### NavBar
- Used the bootstrap to make it look nicer

#### Reflection on Resources

##### W3Schools
- Helped create the slide show of images on the home page

##### ChatGPT
###### Prompt:
- I am building an airport weather data web app and need a small mission statement to put on the homepage?

###### Response:
- Here's a concise mission statement for your web app:
"Delivering real-time, accurate airport weather data to enhance travel planning and operational efficiency for both travelers and aviation professionals."
You can adjust the tone or focus based on your target audience!




### **Henry Shearer**

#### Competitive Analysis

##### Similar Website
[Aviation Weather](https://aviationweather.gov/
)

##### Investigate Website
- This is a government website that has a ton of current and relevant weather information.
- Information that directly relates to and affects aviation control and airplanes.
- It has multiple different interactive maps that the user can navigate through, each map displaying a different use and data source.
- This website is used for more professional use, giving the option for the user to enter a specific station number to narrow down the area of interest and what important weather conditions there are in that area.
- Besides this, it is a rather simple website and can be navigated easily.

##### Technical Inspection
- On the technical side, it does not seem to have a bootstrap integrated into the site.
- It has many other features like buttons the user can interact with and different APIs for weather data implemented into the maps.
- There is also the use of dropdown arrows that lead users to the different pages they choose.

##### Summary
- In summary, I believe that this website can be used to help our project with ideas and what actually needs to be done. It can help by showing us things we might want to implement, and some things we cannot implement because some features are just too advanced for what we are learning to be able to do them ourselves. It even has a login page and help/support pages that our group was looking to put into our own page, so this is also beneficial for ideas. This website will be a great source and help to me and our group in moving forward.



#### GitHub Research

##### Explore Repos
[Weather Forecast Static Webpage](https://github.com/vanaj-418/Weather-Forecast-static-Webpage)

##### Analyze README
- The README for this specific repository just gives a basic overview of what the webpage has to offer and what components it has. It is pretty short and does not go into much detail on what is actually in the webpage. It is all about the webpage being a static website for weather forecasting.

##### Summary
- In summary, this repository is not super in-depth and not a very complex web page itself. It actually only has an image, a README, an index page, and a styles page. I still chose this repository because of how in-depth the index page goes with HTML and what my group might need for help in our project. I just think the repo is similar to what we are trying to build on a basic level and can help us in the future.



#### Prototype Dev

##### Webpage
###### Resources page



#### Document Individual Contributions

##### README
- Resources page









