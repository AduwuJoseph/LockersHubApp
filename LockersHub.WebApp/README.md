# LockersHub
Skill test assessment for Oceangrsmith.
**How it works?**
When a user search for a locker using city or state. A drop down should show displaying location locker
and if the location has more than one locker, then it should show all the lockers of that location. For
example using search for Ikeja and there is only one locker in Ikeja, the dropdown should show Ikeja -
locker 1 And if the using search for Lekki and there are 3 lockers in Lekki, then the dropdown should show,
Lekki locker 1, Lekki locker 2 and Lekki locker 3.
LockersHub is developed using Asp.Net Core. It has Asp.Net Core (Library Classes – to create my data access layer DL and business logic BL, Web API – to create the API for the application; the API is hosted on Azure web services and finally the Web Application – to consume the API via jQuery and bootstrap to arrive at the solution). The application takes a 3-tier architecture design approach to separate concerns being the reson we have the various layers of the application.
Application Break Down
LoockersHub.API – Asp.net Core Web API that implements the DAL and DL
LockersHub.BL – Asp.Net Core Class Library that is used to create the business logic where data is handled and passed to the DAL for persistence.
LockersHub.DAL – Asp.Net Core Class Library that uses EntityFrameworkCore to Handle the data received from the BL for persistent
LockersHub.WebApp - The front end that uses Asp.Net Core Razor pages (MVC) to implement and consume the API using jQuery to arrive at the completion of the task.

Github Url: https://github.com/AduwuJoseph/LockersHubApp
Demo Url: http://lockershub.mya1projects.com/

Demo Images:
Find By State
 
Find by City
 

Successful Rent Now Page
 
