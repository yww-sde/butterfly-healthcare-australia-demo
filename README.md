# Calculator API

A simple RESTful calculator web service built with ASP.NET Core that performs basic arithmetic operations.

## Features

- Basic arithmetic operations (addition, subtraction, multiplication, division)
- Input validation
- Error handling
- Swagger documentation
- Unit tests
- Clean architecture
- Application Insights integration(Planned)
- Health monitoring(Planned)
- Infrastructure as Code with Terraform(Planned)
- CI/CD with GitHub Actions

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or VS Code
- Azure subscription(Optional)
- Terraform
- Azure CLI

## Project Structure

```
src/
  ├── MyCalculator.Api/           # Web API layer
  ├── MyCalculator.Application/   # Application services and DTOs
  ├── MyCalculator.Domain/        # Core business logic
  └── MyCalculator.Infrastructure/# Infrastructure concerns
tests/
  ├── MyCalculator.UnitTests/     # Unit tests
  └── MyCalculator.IntegrationTests/ # Integration tests
infra/                           # Terraform configuration
  ├── main.tf                    # Main Terraform configuration
  ├── variables.tf               # Variable definitions
  ├── outputs.tf                 # Output definitions
  └── terraform.tfvars          # Variable values
.github/
  └── workflows/                 # GitHub Actions workflows
```

## Getting Started

### Local Development

1. Clone the repository
2. Navigate to the project directory
3. Run the application:
   ```bash
   cd MyCalculator.Api
   dotnet run
   ```
4. Open a browser and navigate to `https://localhost:5001/swagger` (or any prompted in terminal) to view the API documentation

### Infrastructure Deployment(Planned)

1. Install Azure CLI and login:
   ```bash
   az login
   ```

2. Navigate to the infrastructure directory:
   ```bash
   cd infra
   ```

3. Initialize Terraform:
   ```bash
   terraform init
   ```

4. Plan the deployment:
   ```bash
   terraform plan
   ```

5. Apply the infrastructure:
   ```bash
   terraform apply
   ```

### CI/CD Pipeline

The project includes a GitHub Actions workflow that:
1. Builds and tests the application
2. Deploys infrastructure using Terraform
3. Deploys the application to Azure App Service

Required GitHub Secrets:
- `AZURE_CREDENTIALS`: Azure service principal credentials
- `AZURE_CLIENT_ID`: Azure service principal client ID
- `AZURE_CLIENT_SECRET`: Azure service principal client secret
- `AZURE_SUBSCRIPTION_ID`: Azure subscription ID
- `AZURE_TENANT_ID`: Azure tenant ID

## API Endpoints

### POST /api/calculator/calculate

Performs a calculation based on the provided operation.

Request body:
```json
{
  "a": 10,
  "b": 5,
  "operator": "+"  // Supported operators: +, -, *, /
}
```

Response:
```json
{
  "result": 15,
  "operation": "10 + 5",
  "success": true,
  "errorMessage": null
}
```

### GET /health

Returns the health status of the API.

## Monitoring and Logging

- Application Insights dashboard: Monitor request rates, response times, and failures
- Health check endpoint: `/health` for service status
- Structured logging with Serilog

## Running Tests

```bash
dotnet test
```

## Built With

- ASP.NET Core 8.0
- Swagger/OpenAPI
- xUnit
- Serilog
- Application Insights
- Terraform
- GitHub Actions