# ASP.NET Core MVC Project Tracker

## Project Overview

This is a simple **Project Tracker** web application developed using **ASP.NET Core MVC**. The application allows users to track projects, including their names, descriptions, statuses, and deadlines. For simplicity, the project data is stored in an in-memory array, eliminating the need for a database setup. The application is also deployed to **Azure App Services** for cloud accessibility.

## Features

- **Project Management**: Add, edit, and delete projects with details such as name, description, status, and deadline.
- **In-Memory Data Storage**: Utilizes an in-memory array to store project data, simplifying the setup and eliminating database dependencies.
- **Cloud Deployment**: Deployed on Azure App Services for easy access and scalability.

## Technologies Used

- **Framework**: ASP.NET Core MVC
- **Language**: C#
- **Frontend**: Razor Views with HTML, CSS, and JavaScript
- **Deployment**: Azure App Services

## Installation & Setup

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (latest stable version)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Azure Account](https://azure.microsoft.com/en-us/free/) (for deployment)

### Steps to Run Locally

1. **Clone the repository**:
   ```bash
   git clone https://github.com/SHAJAR5110/ASP.NET-Core-MVC-Project-Tracker.git
   cd ASP.NET-Core-MVC-Project-Tracker/ProjectTrackerApp
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Run the application**:
   ```bash
   dotnet run
   ```

4. **Access the application**:
   Open your browser and navigate to `http://localhost:5000`.


## License

This project is open-source and available under the [MIT License](LICENSE).

---

