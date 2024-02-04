# Demo.Project
 the Demo Project repository! This project demonstrates a simple CRUD (Create, Read, Update, Delete) operation using ASP.NET Core 8.0.

## Prerequisites
Before you begin, ensure you have the following installed on your machine:

1-.NET SDK 8.0 . <br>
2-Visual Studio .

## Getting Started
Clone the repository: <br>
bash <br>
Copy code <br>
git clone https://github.com/Afnan-Elsebaiy/Demo.Project.git <br>
cd Demo.Project <br>
Open the project in Visual Studio or your preferred code editor.<br>
Run the application

## Project Structure
## Using Three Tier:
 BLL (Bussiness Logic Layer) : 
 Models: Defines the data models used in the application.
 -Service
        -DepartmentService.cs
           - Class DepartmentService
           -Interface IDepartmentService
DAL (Data Access Layer):
 -DataBase 
    -ApplicationContext.cs : Database Configuration.
 -Entity
    -Department.cs : 

Web (UI) <br>
 -Controllers: Contains the controllers for handling HTTP requests. <br>
 -Views: UI/UX using bootstrap. <br>
Program.cs: Configures services and the request processing pipeline. <br>
CRUD Operations
The CRUD operations are implemented in the Controllers folder. You'll find methods for creating, reading, updating, and deleting data.

## Technologies Used
•	.NET Core . <br>
•	Entity Framework Core. <br>
•	ASP.NET Core. <br>


## Dependencies
•	Microsoft.EntityFrameworkCore <br>
•	Microsoft.AspNetCore.Mvc <br>


##vContributing
If you'd like to contribute to this project, please follow these steps:

## Fork the repository.
Create a new branch for your feature: git checkout -b feature/new-feature.<br>
Commit your changes: git commit -m "Add new feature".<br>
Push to your branch: git push origin feature/new-feature.<br>
Open a pull request.<br>








    

