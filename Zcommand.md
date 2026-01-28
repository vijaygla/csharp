```csharp
dotnet run
dotnet run Program.cs
dotnet new --list
dotnet new console -n ProjectName
dotnet new nunit -n ProjectName
dotnet add package SinglePackageName
dotnet new sln -n UnitTestingPractice
dotnet new nunit -n UnitTestingPractice
dotnet build
```

```csharp
dotnet new sln -n UnitTestingPractice

dotnet new classlib -n UnitTestingPractice.Core
dotnet new nunit -n UnitTestingPractice.Tests

dotnet sln add UnitTestingPractice.Core
dotnet sln add UnitTestingPractice.Tests

dotnet add UnitTestingPractice.Tests reference UnitTestingPractice.Core
```

```csharp
dotnet new sln -n AddressBookSolution
dotnet new console -n AddressBookSystem -o src/AddressBookSystem
dotnet new xunit -n AddressBookSystem.Tests -o tests/AddressBookSystem.Tests
dotnet sln add src/AddressBookSystem/AddressBookSystem.csproj
dotnet sln add tests/AddressBookSystem.Tests/AddressBookSystem.Tests.csproj
dotnet add tests/AddressBookSystem.Tests reference src/AddressBookSystem
```

```
