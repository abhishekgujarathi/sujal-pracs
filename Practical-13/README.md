# Practical-13

## Test 1 [Practical-13_1]
Controllers:
- EmployeeController

Action methods: 
- Index 
- Create [GET] 
- Create [POST] 
- Update [GET] 
- Update [POST] 
- Delete [GET] 
- DeleteConfirmed [POST]

Views:
- Views/Employee/Index.cshtml
- Views/Employee/Create.cshtml
- Views/Employee/Update.cshtml
- Views/Employee/Delete.cshtml

Models:
- Entities:
  - Employee.cs
- Data:
  - EmployeeConfig.cs
  - EmployeeDbContext.cs
- Repository:
  - Interface: IEmployeeRepository.cs
  - Implementation: EmployeeRepository.cs
- Services:
  - Interface: IEmployeeService.cs
  - Implementation: EmployeeService.cs

## Test 2 [Practical-13_2]
Controllers:
- DesignationController
Action methods: 
  - Index
  - Create [GET]
  - Create [POST]
  - Update [GET]
  - Update [POST]
  - Delete [GET]
  - DeleteConfirmed [POST]


- EmployeeController
Action methods:
  - Index
  - Create [GET]
  - Create [POST]
  - Update [GET]
  - Update [POST]
  - Delete [GET]
  - DeleteConfirmed [POST]

- HomeController
Action methods: 
  - Index
  - GetEmployeeCountByDesignation

Views:
  - Views/Designation/Index.cshtml
  - Views/Designation/Create.cshtml
  - Views/Designation/Update.cshtml
  - Views/Designation/Delete.cshtml
  - Views/Employee/Index.cshtml
  - Views/Employee/Create.cshtml
  - Views/Employee/Update.cshtml
  - Views/Employee/Delete.cshtml
  - Views/Home/Index.cshtml

Models:
- Configuration:
  - DesignationConfiguration.cs
  - EmployeeConfiguration.cs
- Entities
  - Designation.cs
  - Employee.cs
- Repository:
  - Interface: 
    - IDesignationRepository.cs 
    - IEmployeeRepository.cs
  - Implementation: 
    - DesignationRepository.cs 
    - EmployeeRepository.cs,
- Service:
  - Interface: 
    - IDesignationService.cs
    - IEmployeeService.cs
  - Implementation: 
    - DesignationService.cs
    - EmployeeRepository.cs,
- ViewModels
  - EmployeeViewModel.cs
  - EmployeeCountByDesignationViewModel.cs