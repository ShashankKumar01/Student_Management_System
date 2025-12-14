StudentResultManagement/README.md
# Student Result Management System

A web-based Student Result Management System built with ASP.NET Core Razor Pages (.NET 9, C# 13). This application streamlines the management of students, subjects, exams, marks, and results for educational institutions. It provides an intuitive interface for administrators and staff to efficiently handle student records and academic results.

---

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Database Setup](#database-setup)
  - [Running the Application](#running-the-application)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)

---

## 🚀 Features

- **Student Management:** Add, edit, view, and delete student records.
- **Subject Management:** Manage subjects offered by the institution.
- **Exam Management:** Create and manage exams for different classes and subjects.
- **Marks Entry:** Enter and update marks for students in various subjects and exams.
- **Result Generation:** View and manage student results, including detailed breakdowns.
- **Responsive UI:** Clean, user-friendly interface using Razor Pages and Bootstrap.
- **Role-based Actions:** (Extendable) for admin/staff roles.

---

## 🛠 Tech Stack

- **Framework:** ASP.NET Core Razor Pages (.NET 9)
- **Language:** C# 13
- **Database:** Entity Framework Core (default: SQL Server, configurable)
- **UI:** Razor Views, Bootstrap
- **IDE:** Visual Studio 2022

---

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- SQL Server (Express or above) or LocalDB

### Installation

1. **Clone the repository:**
2. **Open the solution in Visual Studio 2022.**

### 🗄 Database Setup

1. **Configure the connection string:**
- Edit `appsettings.json` to set your SQL Server connection string under `ConnectionStrings:DefaultConnection`.

2. **Apply migrations to create the database:**
- Open the Package Manager Console and run:
  ```powershell
  Update-Database
  ```

### Running the Application

- Press `F5` or click the "Start" button in Visual Studio to launch the application.
- The app will open in your default browser at `https://localhost:xxxx/`.

---

## 📂 Project Structure
StudentResultManagement/ │ ├── Controllers/                # Handles HTTP requests and business logic │   ├── StudentsController.cs │   ├── SubjectsController.cs │   ├── ExamsController.cs │   ├── MarksController.cs │   └── ResultsController.cs │ ├── Models/                     # Entity models for EF Core │   ├── ApplicationDbContext.cs │   ├── Student.cs │   ├── Subject.cs │   ├── Exam.cs │   └── Mark.cs │ ├── ViewModels/                 # View models for passing data to views │   └── ResultViewModel.cs │ ├── Views/                      # Razor views for UI │   ├── Shared/ │   │   └── _Layout.cshtml │   ├── Students/ │   │   ├── Index.cshtml │   │   └── Create.cshtml │   ├── Subjects/ │   │   └── Index.cshtml │   ├── Results/ │   │   ├── Index.cshtml │   │   ├── ViewResult.cshtml │   │   └── NoResult.cshtml │   └── ... │ ├── Migrations/                 # Entity Framework Core migrations │   └── 20251204165034_InitialCreate.cs │ ├── appsettings.json            # Application configuration ├── Program.cs                  # Application entry point └── README.md                   # Project documentation

---

## Usage

### Student Management

- Navigate to **Students** to add, edit, view, or delete student records.
- Each student has a Roll Number, Name, Class, Section, and Date of Birth.

### Subject & Exam Management

- Use **Subjects** and **Exams** sections to manage academic offerings and scheduled exams.

### Marks Entry

- Enter marks for students in each subject and exam via the **Marks** section.

### Result Viewing

- View individual or class results in the **Results** section.
- Detailed breakdowns and summary views are available.

---

## Screenshots

<img width="1845" height="894" alt="image" src="https://github.com/user-attachments/assets/64863b48-0d52-4ae9-a79c-9a0b184b2ce1" />
<img width="1867" height="568" alt="image" src="https://github.com/user-attachments/assets/abb0f11c-bd01-472b-bb32-9fdbf19b91ce" />


---

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

1. Fork the repo
2. Create your feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -am 'Add new feature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a pull request

---

## 👨‍💻 Author
Shashank Kumar Backend Developer | ASP.NET Core | SQL Server

---

## Contact

For questions or support, please open an issue on the [GitHub repository](https://github.com/ShashankKumar01/Student_Management_System).
