# Students

The purpose of current project is to practice building multilayer applications.
It includes the following projects:

* BusinessLogicLayer. This project is connected to the CommonLayer and DataAccessLayer projects.
** StudentBLL.cs file is responsible for business logic. It takes data from Data Access Layer, process it and pass to the Presentation Layer to be displayed.

* CommonLayer contains entities.
** StudentEntity.cs file creates the correspondent class with all needed properties.

* DataAccessLayer. This project relates to the CommonLayer project to create student entities wile fetching the data from the database.
** StudentDAL.cs file is responsible for fetching the data from the database.
** StudentsContext.cs file is responsible for communication with database by means of Entity Framework. 

* PresentationLayer. This project is connected with Business Logic Layer and Common Layer. It is built on ASP.NER Razor Pages.

The application utilizes local MS SQL Server database.