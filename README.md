# Maginengineer Managierre

#### By _**Ryan Bass** (/probablynotryan)_ 

#### _Epicodus Independent Project Week 11: Another MVC website demonstrating familiarity with using and manipulating SQL databases (many-to-many)._

## Technologies Used

* C#
* HTML
* Javascript
* CSS
* Bootstrap
* ASP .NET Core
* MySql
* Entity / Linq / Razor

## Description

An expansion of HairSalon -- this time with many to many relationships! Watch as the database goes to hard to work with many options of engineers and machines.

## Setup/Installation Requirements

* Download or clone this repository to your computer.
* Install [.NET 5](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) if it is not installed already.
* In order to properly run the database, [install MySQL](https://dev.mysql.com/downloads/mysql/).
* In your terminal, type in ```dotnet tool install --global dotnet-ef``` to install dotnet ef.
* Then, log into MySql by entering: ```mysql -uroot -p```
* Type in the password provided during MySql installation.
* Create the salon's database by entering: ```CREATE DATABASE factory;```
* Exit MySql by typing ```quit``` in your terminal.
* Still in terminal, navigate to your downloaded repository. _(ie: User/desktop/Factory.Solution/)_
* Enter in ```mysql -u root -p factory < ryan_bass.sql``` to copy in the tables used in this project. (You'll need to enter your password in again.)
* (We're still using terminal) Navigate to inside Factory.Solution/Factory and enter ```touch appsettings.json```. You can then edit that created file with a code editor of your choice and enter this on in it, followed by saving the file. (Be sure to replace PASSWORD with the password you provided during installation).: 
  ```csharp
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=PASSWORD;"
    }
  } 
  ```
* (Guess what: we're still using terminal from inside Factory/) Enter ```dotnet build```
* After a successful build, run the project by entering ```dotnet run``` (you guessed it: in terminal).
* You should get a _Now listening on:_ line with the path of where its running. (ie: http://localhost.5000) Hold command and click it to open it up with your default browser.
* Go wild!

## Known Bugs

* No reported bugs (yet)

## License

MIT
Copyright (c) _2022_ _Ryan Bass_