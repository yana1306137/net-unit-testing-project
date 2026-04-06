# Discount Solution

Enterprise-grade .NET 8 application demonstrating clean architecture, strict typing, and comprehensive unit testing practices.

## Setup

1. Ensure the .NET 8 SDK is installed on your machine.
2. Clone this repository.
3. Restore packages:
   ```bash
   dotnet restore DiscountSolution.sln
   ```

## Running Tests

To run the unit test suite with xUnit, execute the following command from the root directory:

```bash
dotnet test DiscountSolution.sln
```

### Expected Output

```text
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: < 1 s - tests/Unit/Integration/bin/Debug/net8.0/UnitTests.dll (net8.0)
```
