# Diffy - C# Port

This is a C# port of the [Diffy](https://github.com/opendiffy/diffy) application, which is a differencing engine that compares HTTP responses from different service implementations.

## Project Structure

```
src/
└── Diffy/
    ├── Domain/
    │   ├── Analysis/      # Analysis domain models
    │   ├── Proxy/         # HTTP proxy domain models
    │   └── Repository/    # Repository domain models
    ├── Repositories/      # Data access layer (future)
    ├── Services/          # Business logic layer (future)
    └── Utils/             # Utility classes (future)
```

## Domain Classes Converted

The following domain classes have been converted from Java to C#:

### Analysis Domain
- **FieldDifference** (`Domain/Analysis/FieldDifference.cs`) - Represents a difference in a field between two responses

### Repository Domain
- **Noise** (`Domain/Repository/Noise.cs`) - MongoDB document representing noisy fields for an endpoint

### Proxy Domain
- **HttpMessage** (`Domain/Proxy/HttpMessage.cs`) - Base class for HTTP messages
- **HttpRequest** (`Domain/Proxy/HttpRequest.cs`) - Represents an HTTP request
- **HttpResponse** (`Domain/Proxy/HttpResponse.cs`) - Represents an HTTP response

## Technologies Used

- .NET 8.0
- ASP.NET Core
- MongoDB.Driver 3.5.2
- Swagger/OpenAPI

## Building the Project

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the project
dotnet run --project src/Diffy/Diffy.csproj
```

## Development Notes

- The project follows C# naming conventions (PascalCase for properties, camelCase for parameters)
- Properties use C# auto-properties with getters and setters
- The MongoDB attributes are used for the Noise domain model
- The project structure mirrors the Java package structure but uses C# namespace conventions

## Next Steps

1. Convert repository interfaces and implementations
2. Convert utility classes
3. Convert service classes
4. Implement controllers (equivalent to Java's @RestController classes)
5. Configure dependency injection
6. Add unit tests
