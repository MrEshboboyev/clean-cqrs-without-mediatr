# Clean CQRS without MediatR ![CQRS](https://img.shields.io/badge/CQRS-Clean-brightgreen?style=flat&logo=checkmarx)

A clean implementation of the CQRS (Command Query Responsibility Segregation) pattern using custom dispatchers instead of the MediatR library. This repository demonstrates a clear and maintainable approach to handling complex business logic in ASP.NET Core applications.

## ![Overview](https://img.shields.io/badge/Overview-blue?style=flat&logo=info)

This repository provides an implementation of the CQRS pattern without using the MediatR library. Instead, it uses custom dispatchers to handle commands and queries, offering a straightforward and modular approach to managing complex business logic.

## ![Features](https://img.shields.io/badge/Features-yellow?style=flat&logo=star)

- Clean implementation of CQRS pattern
- Custom command and query dispatchers
- Domain-Driven Design principles
- Unit and integration tests
- ASP.NET Core web application

## ![Getting Started](https://img.shields.io/badge/Getting_Started-red?style=flat&logo=rocket)

### Prerequisites

Ensure you have the following installed:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or any other preferred IDE
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other preferred database

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/MrEshboboyev/clean-cqrs-without-mediatr.git
    cd src
    ```

2. Restore the NuGet packages:

    ```bash
    dotnet restore
    ```

## ![Usage](https://img.shields.io/badge/Usage-green?style=flat&logo=play)

### Running the Application

To run the application, use the following command:

```bash
dotnet run
```

The application will start on `https://localhost:5001` by default.

### Examples

- **Create Product**: Send a POST request to `/products` with the user details.
- **Get User by ID**: Send a GET request to `/products/{productId}`.

## ![Project Structure](https://img.shields.io/badge/Project_Structure-purple?style=flat&logo=directory)

```plaintext
src
├── Api
│   ├── Dependencies
│   ├── Properties
│   ├── Commands
│   │   └── CreateProduct
│   ├── Extensions
│   ├── Models
│   ├── Queries
│   │   └── GetProductById
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   └── Program.cs
├── Shared
│   ├── Dependencies
│   ├── Common
│   │   ├── ICommandDispatcher.cs
│   │   ├── ICommandHandler.cs
│   │   ├── IQueryDispatcher.cs
│   │   └── IQueryHandler.cs
│   └── Implementations
│       ├── CommandDispatcher.cs
│       └── QueryDispatcher.cs
```

## ![Contributing](https://img.shields.io/badge/Contributing-orange?style=flat&logo=git)

Contributions are welcome! Please open an issue or submit a pull request if you have any improvements or new features to add.

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes.
4. Push the branch.
5. Open a pull request.

## ![License](https://img.shields.io/badge/License-MIT-blue?style=flat&logo=law)

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## ![Acknowledgements](https://img.shields.io/badge/Acknowledgements-thanks?style=flat&logo=handshake)

- Special thanks to the contributors of this project.
- Inspired by the principles of Clean Architecture and Domain-Driven Design.
