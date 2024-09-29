# Password Generator

## Overview

The **PasswordGenerator** is a Windows Forms application that allows users to upload an Excel file containing usernames and passwords. The application hashes the passwords using .NET Core Identity features and enables users to download the results in a new Excel file. This tool is designed for ease of use and efficient password management.

## Technologies Used

- **.NET 8.0**: The latest version of the .NET framework for building Windows applications.
- **Windows Forms**: A UI framework for building Windows desktop applications.
- **Entity Framework Core**: An ORM (Object-Relational Mapping) framework for database interactions.
- **ASP.NET Core Identity**: Provides a way to manage user authentication and authorization.
- **EPPlus**: A library for reading and writing Excel files.
- **C#**: The programming language used for developing the application.

## Features

- Upload Excel files with usernames and passwords.
- Hash passwords using the ASP.NET Core Identity PasswordHasher.
- Download results as an Excel file with hashed passwords.
- User-friendly interface built with Windows Forms.

## How to Publish the Application

To publish the application as a single executable file, follow these steps:

### Prerequisites

- Ensure you have the .NET SDK installed on your machine. You can download it from the [official .NET website](https://dotnet.microsoft.com/download).

### Steps to Publish

1. **Open Command Prompt or PowerShell**.
2. **Navigate to your project directory** using the `cd` command:
   ```bash
   cd path\to\your\PasswordGenerator\project
   ```
3. **Run the publish command:**
  ```bash
  dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
  ```
4. **Locate the Executable: After publishing, navigate to:**
   ```bash
   \bin\Release\net8.0-windows\win-x64\publish\
   ```

### Project Overview
![Demo Image](https://raw.githubusercontent.com/mehedihasan9339/PasswordGenerator/refs/heads/master/PasswordGenerator/demo.png)
