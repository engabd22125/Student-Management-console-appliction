# Student Management Console Application

A simple **Student Management System** built with **C#** as a console application.

This project was created to practice and apply fundamental C# programming concepts such as **Classes, Methods, Dictionaries, Lists, Loops, Conditional Statements, and Basic Object-Oriented Programming**.

## Features

* Add new students
* Add multiple grades for a student
* Display all students and their grades
* Calculate and display students' averages
* Find the student with the highest average
* Simple interactive console menu
* Case-insensitive student name handling

## Menu

```text
1. Add Student
2. Add Grade
3. Show Student
4. Show Highest Average
5. Exit
```

## Technologies Used

* **C#**
* **.NET**
* **Console Application**
* `Dictionary<string, List<int>>`
* Object-Oriented Programming (OOP)

## Project Structure

```text
Student-Management-console-appliction/
│
├── studentManger.cs
├── student mangment.csproj
├── README.md
└── .gitignore
```

## How It Works

The application stores each student using a dictionary:

```csharp
Dictionary<string, List<int>>
```

The student's name is used as the key, while their grades are stored inside a `List<int>`.

Example:

```text
Ali => 85,90,78
Ahmed => 70,88,92
Sara => 95,91,89
```

The application can then calculate the average of each student's grades and determine who has the highest average.

## Getting Started

### Requirements

* .NET SDK
* Windows, Linux, or macOS
* A code editor such as Visual Studio or Visual Studio Code

### Run the Project

Clone the repository:

```bash
git clone https://github.com/engabd22125/Student-Management-console-appliction.git
```

Navigate to the project directory:

```bash
cd Student-Management-console-appliction
```

Run the application:

```bash
dotnet run
```

## Example

```text
Menu:
1. Add Student
2. Add Grade
3. Show Student
4. Show Highest Average
5. Exit

enter your number: 1

enter the name's: Ali
```

After adding grades:

```text
Ali => 85,90,95
Ahmed => 70,80,75
```

The application can determine the highest average student.

## Learning Objectives

This project helped me practice:

* C# syntax and fundamentals
* Classes and objects
* Methods
* `Dictionary`
* `List`
* `foreach` and `for` loops
* `switch` statements
* Conditional statements
* String manipulation
* Basic data management
* Calculating averages
* Console-based application design

## Future Improvements

Possible improvements for future versions:

* Prevent duplicate student names
* Validate user input
* Add student deletion
* Update existing grades
* Display individual student information
* Add student IDs
* Improve the user interface
* Store data permanently using a database
* Add **SQL Server** integration
* Refactor the project using better OOP principles

## Author

**engabd22125**

This project is part of my journey in learning **C# and .NET development**.
