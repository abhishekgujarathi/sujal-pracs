# Practical-12

## Test 1

Controller:
- EmployeeController.cs

Action Methods:
- Index
- Insert [GET]
- Insert [POST]
- UpdateFirstName
- UpdateMiddleName
- DeleteLessThanTwo
- DeleteAll

Models:
- Entities:
    - Employee.cs

- Repositories:
    - EmployeeRepository.cs

- Services:
    - EmployeeService.cs

- ViewModels:
    - EmployeeDetailsViewModel.cs

Views:
- Views/Employee/Insert.cshtml
- Views/Employee/Index.cshtml

## Test 2

Controller:
- EmployeeTwoController.cs

Action Methods:
- Index
- Insert
- GetBefore2000
- GetTotalSalary
- CountNullMiddleName

Models:
- Entities:
    - EmployeeTwo.cs

- Repositories:
    - EmployeeTwoRepository.cs

- Services:
    - EmployeeTwoService.cs

- Data:
    - EmployeeTwoSeeder.cs

Views:
- Views/EmployeeTwo/Index.cshtml

## Test 3

Controller:
- Controllers/EmployeeThreeController.cs

Action Methods:
- Index()
- InsertEmployee() [GET]
- InsertEmployee(EmployeeThree emp) [POST]
- InsertDesignation() [GET]
- InsertDesignation(Designation desg) [POST]
- DisplayEmployeesByDesignationStoredProcedure(int id)
- CreateIndex()

Models:
- Entities:
    - Designation.cs
    - EmployeeThree.cs

- Repositories:
    - EmployeThreeRepository.cs

- Services:
    - EmployeeThreeService.cs

- ViewModels:
    - DesignationCountViewModel.cs
    - DesignationMoreThanOneViewModel.cs
    - EmployeeDetailsByDesignationViewModel.cs
    - EmployeeWithDesignationViewModel.cs
    - DashboardViewModel.cs
    - EmployeeDetailsViewModel.cs

Views:
- Views/EmployeeThree/Index.cshtml
- Views/EmployeeThree/InsertDesignation.cshtml
- Views/EmployeeThree/InsertEmployee.cshtml
- Views/EmployeeThree/_CountByDesignation.cshtml
- Views/EmployeeThree/_DisplayByDesignation.cshtml
- Views/EmployeeThree/_DisplayByStoredProcedure.cshtml
- Views/EmployeeThree/_DisplayByView.cshtml
- Views/EmployeeThree/_EmployeeByDesignation.cshtml
- Views/EmployeeThree/_MaxSalaryEmployee.cshtml
- Views/EmployeeThree/_MoreThanOneDesignation.cshtml
