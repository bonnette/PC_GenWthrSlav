# PC_GenWthrSlav
PC Version of a weather slave
<br>
![Client Photo](https://github.com/bonnette/PC_GenWthrSlav/blob/master/GenWthrSlav.png)
<br>
This Project is a variation of my FSgenweather project. The FS in "FSgenslave" stands for Full Screen. The "gen" in the name stands for "general" in that instead of 
grabbing data from a "SwitchDoc" weather station at the house. The weather data is derived from an api provided by openweathermap.com as well as Newtonsoft.Json.Linq to extract 
json data from the website.
The "slav" in "GenWthrSlav" indicates that the project solves a problem.</br>
The Problem: "openweathermap.com" allows a limited number of queries each day. I was able to run one weather client using openweathermap.com but found that I hit the limits 
allowed by openweathermap.com if I tried to run two or more units.</br>
The fix for this problem was to have one master in the house that asked openweathermap.com for the weather (the master) and then have a slave ask the master for the weather
information instead of going to openweathermap.com for it.</br> 

This app is written from scratch using Microsofts Visual Studio 2022 and Visual Basic.</br>

The "Master" is a Raspberry Pi that queries the openweather website. </br>

The operation goes like this:</br></br>
- Every 3 minutes the master gets weather data from openweathermap.com.</br>
- When the "Get Weather" button is pressed the slave copies the weather data (wthr.dat) from the master to the slave.</br>
- Every 3 minutes the master displays the weather data on its TFT the slave displays only after the button pressed. </br>
