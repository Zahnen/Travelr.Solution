<br>
<h1 align = "center">
  <b> Travelr </b>
</h1>

<p align = "center">
  This is a custom API that allows users to read and post reviews about various travel destinations
</p>
<p align = "center"> Created January 19, 2021 </p>

<p align = "center">
  By Kaila Sprague McRae & Zahnen Garner
</p>

--------------------

## 📖  Description

This is a custom API that allows users to read and post reviews about various travel destinations.

This is a practice project for Epicodus week 13 as part of the "Building and API" coursework. 

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3.0
- .NET Core v2.2.0
- ASP .NET MVC
- ASP .NET Core Razor Pages
- MySQL
- MySQL Workbench
- Entity Framework Core
- Postman

-------------------

## Specifications

<details>
<summary>User Stories</summary>

| Story# | User Story | Complete |
| :------------- | :------------- | :------------- |
| 01 | As a user, I want to GET and POST reviews about travel destinations. | ✅ |
| 02 | As a user, I want to GET reviews by country or city. | ✅  |
| 03 | As a user, I want to see the most popular travel destinations by number of reviews or by overall rating. | ❌ |
| 04 | As a user, I want to PUT and DELETE reviews, but only if I wrote them. | ❌ |
| 05 | As a user, I want to look up random destinations just for fun. | ❌ |

</details>

-------------------

## 🐛 Known Bugs



| Date | Error | Handled | Solution |
| :------------- | :------------- | :------------- | :------------- |
| 01.19.2021 | No known bugs at this time |  |  |

-------------------

## 🔧 Setup & Requirements

### 📋 Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)
- **Prefered Code Editor**


### ⚙️ Clone or Download

#### To Download:

Go to my GitHub repository here, [https://guthub.com/kaila.spraguemcrae/Travel.Solution](https://guthub.com/kaila.spraguemcrae/Travel.Solution), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### To clone (my prefered method):

1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/kaila-spraguemcrae/Travel.Solution`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.

### 🧰 Database Setup Options

#### AppSettings:

- After you have the project on your computer you will need to create a file in the root directory of the project called "appsettings.json". 
- Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=kaila_spraguemcrae_french_bakery;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```
*Please note you will need to replace `YOUR-PASSWORD-HERE` with the password you created for your MySQL server.
*You may also need to update `uid`, `port`, or `database` name depending on your configurations.

#### Import Database using Entity Framework Core:

 - In the command line run ` cd Desktop/Travel.Solution/Travel` to navigate to the "FrechBakery" folder. 
 - Next, run `dotnet ef database update` to generate the database. You can confirm the database was created by checking MySQL workbench.

*to make changed to the database you can run `dotnet ef migrations add <MigrationName>`

#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'Travel.Solution/Travel' folder (`cd Travel`) in the command line and run `dotnet run` or `dotnet watch run`.
2. At this point you should be able to click on the link to the local server's url path to view the compiled project. 

--------------------------
# 🛸 API Documentation
In order to explore the endpoints of this API, we suggest that you use [Postman](https://www.postman.com/). Postman will allow you to make GET, POST, PUT, and DELETE requests with the TravelrApi.

## JWT Web Token Authorization

- Travelr API uses JWT Web Tokens to authorize users based on their user roles. "User" users are able to make GET requests only, whereas "Admin" users are able to make POST, PUT, and DELETE in addition to GET requests.
- To receive an authorization token, you will first need to authenticate a user in either an "Admin" or "User" role. For the purposes of this API demo, user paramaters have been generated for both roles. Please refer to the below authentication instructions based on the user role you'd like to create.

### "Admin" User Creation

- Create a POST request to http://localhost:5004/api/users/authenticate
- Navigate to the "Body" tab of your request and select "Raw Data" from the offered options followed by "JSON" in the dropdown to the right of your selection. Enter the following code snippet into the body field
```
{
    "Username": "admin",
    "Password": "admin"
}
```
The response will generate a bearer token. Copy this token for use when you create a new request (GET, POST, DELETE, PUT). When creating a new request, navigate to the "Authorizations" tab. Select "Bearer Token" as the authorization type, and paste your copied token into the "Token" field. This token will authorize your requests. 

### "User" User Creation


- Create a POST request to http://localhost:5004/api/users/authenticate
- Navigate to the "Body" tab of your request and select "Raw Data" from the offered options followed by "JSON" in the dropdown to the right of your selection. Enter the following code snippet into the body field
```
{
    "Username": "user",
    "Password": "user"
}
```
The response will generate a bearer token. Copy this token for use when you create a new GET request. When creating a new request, navigate to the "Authorizations" tab. Select "Bearer Token" as the authorization type, and paste your copied token into the "Token" field. This token will authorize your GET requests only. 


## Endpoints

Base URL : `http://localhost:5004`

### HTTP Request Structure

```
GET /api/destination
POST /api/destination
GET /api/destination{id}
PUT /api/destination{id}
DELETE /api/destination{id}
```
### Path Paramaters

| Parameter | Type | Default | Required | Description |
| :------------- | :------------- | :------------- | :------------- |:------------- |
| cityname | string | none | false | Return matches by city name |
| country | string | none | false | Return matches by country name |
| rating | int | none | false | Return matches by rating number between 0-5 |

### Example Query

`http://localhost:5004/api/destination/?country=japan&rating=5`

### Sample JSON Response

```
{
  "Id": 6,
  "CityName": "Tokyo",
  "Country": "Japan",
  "Review": "Best place ever!",
  "Rating": 5
}
```
--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact us:
- [Kaila Sprague McRae](mailto:kaila.sprague@icloud.com)
- [Zahnen Garner](mailto:zahnen@gmail.com) 

---------------------------

## 📘 License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2020 Kaila Sprague McRae & Zahnen Garner