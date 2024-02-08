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

Part 7 (add search to an ASP.NET Core MVC app)
Thursday 2024-02-01 1124

Initially, i did basic Movie Title Search here the Index method initially takes a parameter searchString for movie title search.

Then switched to Using "id" Parameter the method signature is changed to accept a parameter named id instead of searchString.
All occurrences of searchString are replaced with id.

Then completed HTML Form for User Input, In the Views/Movies/Index.cshtml file, a form is added using the Form Tag Helper to allow  to input the search criteria.

Next, HTTP GET Request for Search, to enable to bookmark or share search results, the form method is changed to "get."

Then added Genre Search, a new class MovieGenreViewModel is added to the Models folder, which includes properties for a list of movies, a SelectList of genres, selected genre, and search string.

Updated Index View here the Views/Movies/Index.cshtml file is updated to use the MovieGenreViewModel.
A dropdown list for genres is added, allowing to filter movies by genre.

Display Movie List in View is completed,the movies and their details are displayed in a table in the view using HTML Helper methods.
The table headers and rows are generated dynamically based on the model properties.

Part 8 (add a new field to an ASP.NET Core MVC app)
Thursday 2024-02-01

I added Rating Property to Movie Model, a new property Rating of type string is added to the Movie model.

Then update Binding in MoviesController, In the MoviesController.cs file, the [Bind] attribute is updated for both the Create and Edit action methods.
The Rating property is included in the binding to ensure it is considered during model binding.

Next Updated Index View, In the Views/Movies/Index.cshtml file, the table displaying movies is updated to include a column for the Rating property.
The @Html.DisplayNameFor and @Html.DisplayFor HTML Helpers are used to generate the headers and display the rating for each movie.

Update Create View, the Views/Movies/Create.cshtml file is updated to include a field for entering the movie rating.
The asp-for attribute is set to "Rating" to bind the input field to the Rating property in the model.

Then Updated SeedData, In the SeedData class, sample data for the Rating property is added for one of the movies.
This ensures that the new property has a value when the database is seeded.

I did Database Migration, Code First Migrations is used to update the database schema to include the new Rating property.
The Update-Database command applies the migration to update the database schema.

In the last Verified and Run the App, and it support creating, editing, and displaying movies with the new Rating property.

Part 9 (add validation to an ASP.NET Core MVC app)
Thursday 2024-02-8 1120

Observation: Validation properties are implemented in an ASP.
NET Core Movie class, as demonstrated in the course, with a focus on their importance in maintaining data integrity. 
Important things to remember are to utilize DataType for formatting cues and properties like Required, StringLength, 
and RegularExpression for validation. The lesson emphasizes the advantages of having validation rules centralized in the model class, 
which helps to create a codebase that is organized and easy to maintain. 
It also shows how validation may be used practically, both on the client and server sides, 
making the web application more reliable and user-friendly.

Part 10 (examine the Details and Delete methods of an ASP.NET Core app)
Thursday 2024-02-8 1131

Observation: The code sample demonstrates how the ASP.NET Core Movie controller functions (Delete, DeleteConfirmed, and Details) 
are implemented securely. It highlights how crucial it is to validate movie IDs in order to stop security flaws. 
While the HTTP GET Delete method verifies IDs prior to showing data, the data method collects movie details. 
By using attributes to get around the common language runtime limitation on identical method names and signatures, 
the HTTP POST DeleteConfirmed method safely manages movie deletion. All things considered, the code is a perfect example of
safe HTTP GET and POST procedures in an ASP.NET Core application.












