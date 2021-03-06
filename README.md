# _Pierre's Sweet and Savory Treats_

#### By _**Jacob Wilson**_

#### _An mvc application that allows logged in users to facilitate treat/flavor relations. Non logged in users can only view details while logged in users can create, edit, and delete relationships._

## Technologies Used

* _HTML_
* _C#_
* _CSS_
* _Markdown_
* _Bootstrap_
* _HtmlHelper_
* _SQL_
* _MySQL_
* _EntityFrameworkCore_

## Description

_An mvc application that allows the user to facilitate treat/flavor relations. This project emphasizes practicing many to many relationships and authentication with Entity. The user is able to create a flavor object that can can be assigned to any number of treats or a treat object that be assigned any number of flavors. The project contains a splash page that lists all created objects as well as a navigation bar that can direct you either to both a flavors list a treats list, or to an account management page. The edit, create, and post views are only available to those who have logged in while the details view is available for all._

## Setup/Installation Requirements

* _You can find the github repository [here](https://github.com/JLEWilson/Pierre-sSweetAndSavoryTreats.Solution)_
* _Click the code button, and copy the https link_
* _In your in git bash or your preferred git terminal navigate to the directory you would like to store the project_
* _Enter: "git clone" followed by the https link_
* _Now that the repository is cloned to your computer, right click on the folder and click open with vs code_
* _Once in the project navigate to the PierresTreats directory_
* _Type dotnet restore to install dependencies_
* _In order to initialize a database you will need to create an appsettings.json file that looks like this_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=jacob-wilson;uid={YOUR USER ID HERE};pwd={YOUR PASSWORD HERE};"
  }
}
```
* _Once you have the appsettings.json fie, to create a database run: dotnet ef migrations add Initial_
* _To update the database in MySQL run: dotnet ef database update_
* _At this point you will now be able to view the project by typing dotnet run in the terminal_


## Known Bugs

* _No known bugs_

## License - [MIT](https://opensource.org/licenses/MIT)

_If you run into any problems or find a bug, would like to reach me for a separate reason, feel free to send me an email @jacobleeeugenewilson@gmail.com with details of your issue._

Copyright (c) _01/14/2022_ _Jacob Wilson_