Part 1
Thursday 2024-01-12

@ 0900

- I installed Visual Studio 2022, with the ASP.NET and web development workload then created Web App and created a new project by selecting ASP.NET Core Web App. 
Then configured new project and  the name of the project is MvcMovie. Then launched the app without debugging by selecting Ctrl+F5 
Ran the Visual Studio app and it opens the default browser


Part 2
@ 1100
Firday 2024-01-13
- I completed the second page, added a controller to an ASP.NET Core MVC app, then Added New Scaffolded Item from the dialog box by selecting MVC Controller - Empty
The content that was given in the HelloWorldController replaced with the given content in instructions, the concept of HTTP endpoints in a web application using a controller
It explains that every public method in the controller is callable as an HTTP endpoint, specifying the targetable URL structure here both methods return a string
Then gave HTTPS protocol, network location of the web server, including the TCP port and the target URI HelloWorld and Append /HelloWorld to the path in the address bar. 
The Index method returns a string "This is my default action..." . Then set the routing format in the Program.cs file.
I only browse to localhost:Port/HelloWorld and the Index method was called by default. Index is the default method that will be called on a controller 
if a method name isn't explicitly specified. 
Then browse to ""https://localhost:{PORT}/HelloWorld/Welcome" runs the Welcome method and return string "This is the Welcome action method..." 
Here HelloWorld in controller and Welcome is action method
In this part i did some extra work to learn as i tried with "FoodController" and "PetController" 

@ 1200
In next step, Changed the Welcome method to include two parameters, Useed Interpolated Strings $"Hello {name}, NumTimes is: {numTimes}" 
then run the app and browse "/HelloWorld/Welcome?name=Rick&numtimes=4"  and got "Hello Rick, Numtime is: 4" it was difficult to do in the first time then do google
and search how parameters work and by understanding i did it successfully.

Part 3 (add a view to an ASP.NET Core MVC app)
Saturday 2024-01-14 
1200
In this section, I modified the HelloWorldController class to use Razor view files instead of returning strings, 
this provides an elegant way to send HTML responses using C#. 
The Index method in the controller is updated to return a view, by default it will return the view named Index, 
and a new view template named Index.cshtml is created within the HelloWorld folder in the Views directory.

Next, the tutorial covers changing the layout of the application by modifying the _Layout.cshtml file in the Views/Shared folder. 
This file has the base layout of the application, it includes the header, footer etc elements that remain the same in all views
I updated the title, footer, and menu links. 
The effect of these changes is observed across different pages like Privacy and Home.

The concept of passing data from the controller to the view is introduced, the controller in this case is getting data from the URL parameters 
I modified the HelloWorldController's Welcome method to pass down the URL parameters to the view file. 
A new view template, Welcome.cshtml, is created, extracting parameters from the query string. 
Dynamic data is stored in a ViewData dictionary and rendered in response to browser requests.

The tutorial talks about separation of concerns, 
highlighting the controller's role in providing data to views.
It tells us that the view template should not be used to do business logic and interact with the database,
these need to be done in the controller and final calculations are sent to the views for displaying on the webpage.


Part 4 (add a model to an ASP.NET Core MVC app)
Saturday 2024-01-20 0100

I Created a Data Model Class (POCO class):

A Movie class is created with properties like Id, Title, ReleaseDate, Genre, and Price.
The Id field is marked as the primary key, and the ReleaseDate property is decorated with the DataType attribute to specify the type of data (Date).
The question mark after string indicates that the string properties are nullable

then added NuGet Packages:

Necessary NuGet packages for EF Core are automatically added by Visual Studio.
Scaffold Movie Pages:

The scaffolding tool is used to generate Create, Read, Update, and Delete (CRUD) pages for the Movie model.
MVC Controller with views, using Entity Framework, is selected during scaffolding.

I did Initial Migration:

EF Core Migrations are used to create the initial database schema.
Commands like Add-Migration InitialCreate and Update-Database are executed in the Package Manager Console to generate and apply the migration.

Tested the App:

The app is built and run, and the Movie App link is tested.
An initial error related to the database not existing may occur.

I Examine Generated Database Context Class and Registration:

The MvcMovieContext class is created, derived from DbContext, representing the data context for movies.
Dependency injection is used to inject MvcMovieContext into the MoviesController.
Examine Generated Database Connection String:

Connection string details are added to the appsettings.json file.
I completed Examine the InitialCreate Class (Migration File):

The InitialCreate migration file is generated, containing Up and Down methods for creating and reverting the database schema.
Examine Dependency Injection in the Controller:

The MoviesController constructor uses Dependency Injection to inject the MvcMovieContext.
Examine Strongly Typed Models and @model Directive:
Views are used strongly typed models, allowing for compile-time checking.
Examples are provided for the Details and Index views, where @model directives specify the expected model types.
The tutorial covers the creation of model classes, scaffolding CRUD pages, running migrations, and using strongly typed models in views.
This tutorial provides a comprehensive guide for setting up a basic MVC application with a database using EF Core. It emphasizes important concepts like model creation, dependency injection, 
and strongly typed views.

Part 5 (work with a database in an ASP.NET Core MVC app)
Sunday 2024-01-29 0112

I did database Context Setup:
here the MvcMovieContext class is responsible for connecting to the database and mapping Movie objects to database records.
In the Program.cs file, the AddDbContext method is used to register the MvcMovieContext with the Dependency Injection container. 
It also specifies the connection string from the configuration file.

Then i did connection String Configuration, here connection string is read from the appsettings.json file during local development.

Then Setting up LocalDB, Visual Studio comes with SQL Server Express LocalDB, a lightweight version for development.

Next from the view menu Opened SQL Server Object Explorer (SSOX).By clicking right on the Movie table (dbo.Movie) and choose "View Designer" to see the table structure.
then Right-click on the Movie table and choose "View Data" to inspect the table's records.

Afet that Seeding the Database, Create a class named SeedData in the Models folder with a method named Initialize.

In next step, Seed Data Class the SeedData class checks if there are any movies in the database. If yes, it returns, indicating that the database has already been seeded.
here i did not give any new movie names i ran it with the old name that i gave by myself. 

then added Seed Initializer in Program.cs, in Program.cs, replaced its contents.
It then initializes the database using the SeedData class within a service scope.

Part 6 (controller methods and views in ASP.NET Core)
Thursday 2024-02-01 0146

In this step firstly i did the Model Enhancements, In the Models/Movie.cs file, annotations are added to improve the display of data in the app.

then Tag Helpers and Generated Links, the Views/Movies/Index.cshtml file uses Anchor Tag Helpers for generating Edit, Details, and Delete links dynamically based on the controller actions and route parameters.

Next, Controller Actions and HTTP Methods: The Movies controller contains two Edit action methods, one for HTTP GET and the other for HTTP POST.

then View Template (Edit.cshtml): The Edit view template is generated based on the Movie model and includes Tag Helpers for rendering form elements.

Part 7 ()












