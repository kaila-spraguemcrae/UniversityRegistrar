# University Registrar with Many-to-Many Relationships, Entity & MVC Web Interface

#### Two-day Homework Practice Assignment during Epicodus Coding School, ASP.NET Core MVC Many-to-Many Relationships, 1.4.2021

#### By Kaila Sprague McRae, Eric Endsley, & Danielle Thompson

---

## Description

This web application is for a university registrar to keep track of students & courses with the following functions:

- Keeps track of all students enrolled at the university with name & date or enrollment.
- Keeps track of all the courses the university offers with course name & course number(ex. HIST100).
- Assigns students to a course(s).

Stretch:

- Create departments where a major can be declared by students & a course can be assigned to a department upon creation.
- Lists all the courses and all the students in a particular department.
- Edit a student's file to show course completion status.
- Lists all the courses a student has taken to compare to degree requirements.
- View how many students have not completed courses in any particular department, to see which departments need help.

---

## Technologies used

- C# v 7.3
- .NET Core v 2.2
- MySQL, MySQL Workbench
- Entity Framework Core, CRUD, RESTful routing
- dotnet script, REPL
- ASP.NET MVC Core
- Razor
- VSCode
- [SQL Design Planner](https://ondras.zarovi.cz/sql/demo/)

---

## Installation Requirements

#### Installing Git

###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site.\_
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/eric-endsley/registrar], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/eric-endsley/registrar.git`.

#### Installing C#, .NET, dotnet script, & MySQL

- Install C# and .Net according to your operating system below.

###### For Mac

- Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
- Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
- Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`.

###### For Windows (10+)

- Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
- Open the file and follow the steps provided by the installer for your OS.
- Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems

- Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Setting up a Local Database

TODO

#### Opening the Project on your Local System

Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

- Navigate to the project folder on your Terminal or CMD.
- `dotnet build` will get bin/ and obj/ folders downloaded.
- `dotnet run` will run the application.
- `dotnet restore` to install packages listed in project's boilerplate.

---

## Known bugs

No known bugs as of now.

### Legal, or License

_MIT_ Copyright (c) 2021 _*Kaila Sprague McRae, Eric Endsley, & Danielle Thompson*_
