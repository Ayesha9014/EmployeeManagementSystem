
# Employee Management System (Blazor)

## Overview

This project is a **Blazor-based Employee Management System** that incorporates robust **authentication** and **authorization** features. The application provides an intuitive interface for managing employee records while ensuring data security and controlled access based on user roles.

## Features

### Core Functionality:
- **Employee Management**:
  - Add, edit, delete, and view employee details.
  - Manage key employee attributes, such as department, designation, salary, and contact information.

- **Role-Based Access Control**:
  - Different access levels for administrators, managers, and regular users.
  - Restricted access to sensitive features and data based on roles.

- **Authentication**:
  - Secure user login and registration using modern authentication mechanisms.
  - Integration with **ASP.NET Identity** for user and role management.

- **Authorization**:
  - Role- and policy-based authorization to ensure proper access control.
  - Dynamic navigation and feature visibility based on user roles.

### Advanced Features:
- **Responsive Design**:
  - Built with Blazor components to deliver a seamless user experience across devices.
  - 
- **Export in Excel, Pdf**:
    -The users can export the employee list in excel or pdf.
    -It also has printing options.
  
- **Dashboard**:
  - An interactive dashboard displaying key metrics such as employee count, department distribution, and recent activity.

## Technologies Used

- **Frontend**: Blazor (WebAssembly)
- **Backend**: ASP.NET Core
- **Authentication/Authorization**: ASP.NET Identity and JWT 
- **Database**: SQL Server
- **Entity Framework Core**: For ORM and database interactions
- **Dependency Injection**: For modular and testable code

## Key Security Features

- **Secure Authentication**:
  - Password hashing for safe credential storage.
  - Support for multi-factor authentication

- **Data Validation**:
  - Client-side and server-side validation for employee data.

- **Session Management**:
  - Secure session handling and token expiration mechanisms.

## How to Use

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Ayesha9014/EmployeeManagementSystem
   ```

2. **Set Up the Database**:
   - Run the provided SQL scripts to create the required database and tables.

3. **Update Configuration**:
   - Update the `appsettings.json` file with your database connection string and other necessary configurations.

4. **Run the Application**:
   - Open the solution in Visual Studio.
   - Build and run the project.

5. **Authentication Setup**:
   - Use the built-in admin account (or create one during setup) to access admin functionalities.

## Future Enhancements

- Add support for multi-factor authentication (MFA).
- Integrate email notifications for employee-related updates.
- Implement performance reviews and appraisal tracking.


