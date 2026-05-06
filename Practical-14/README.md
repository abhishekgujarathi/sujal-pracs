# Practical-14

### Test 1: Listing Page
Controllers: 
- EmployeeController  

Action Methods: 
- Index  

Views: 
- Index.cshtml 
- _EmployeeTable.cshtml  

Models: 
- Entity:
    - Employee
- MetaData:
    - EmployeeMetadata.cs
- Repository:
    - Interface: IEmployeeRepository.cs
    - Implementation: EmployeeRepository.cs 
- Service:
    - Interface: IEmployeeService.cs
    - Implementation: EmployeeService.cs 

### Test 2: Create New Record
Controllers: 
- EmployeeController  

Action Methods: 
- Create [GET] 
- Create [POST]  

Views: 
- Create.cshtml  

Models: 
- Entity:
    - Employee
- MetaData:
    - EmployeeMetadata.cs
- Repository:
    - Interface: IEmployeeRepository.cs
    - Implementation: EmployeeRepository.cs 
- Service:
    - Interface: IEmployeeService.cs
    - Implementation: EmployeeService.cs 

### Test 3: Edit Record
Controllers: EmployeeController  

Action Methods: Update (GET), Update (POST)  

Views: Update.cshtml  

Models: 
- Entity:
    - Employee
- MetaData:
    - EmployeeMetadata.cs
- Repository:
    - Interface: IEmployeeRepository.cs
    - Implementation: EmployeeRepository.cs 
- Service:
    - Interface: IEmployeeService.cs
    - Implementation: EmployeeService.cs 

### Test 4: Delete Record
Controllers: 
- EmployeeController  

Action Methods: 
- Delete [GET] 
- DeleteConfirmed [POST]

Views: 
- Delete.cshtml  

Models: 
- Entity:
    - Employee
- MetaData:
    - EmployeeMetadata.cs
- Repository:
    - Interface: IEmployeeRepository.cs
    - Implementation: EmployeeRepository.cs 
- Service:
    - Interface: IEmployeeService.cs
    - Implementation: EmployeeService.cs 

### Test 5: Search Functionality
Controllers: 
- EmployeeController  

Action Methods: 
- Search  

Views: 
- _EmployeeTable.cshtml  

Models: 
- Entity:
    - Employee
- MetaData:
    - EmployeeMetadata.cs
- Repository:
    - Interface: IEmployeeRepository.cs
    - Implementation: EmployeeRepository.cs 
- Service:
    - Interface: IEmployeeService.cs
    - Implementation: EmployeeService.cs 

### Test 6: Paging Functionality
Controllers: 
- EmployeeController  

Action Methods: 
- Index
- Search  

Views: 
- Index.cshtml 
- _EmployeeTable.cshtml  

Models: 
- Entity:
    - Employee
- MetaData:
    - EmployeeMetadata.cs
- Repository:
    - Interface: IEmployeeRepository.cs
    - Implementation: EmployeeRepository.cs 
- Service:
    - Interface: IEmployeeService.cs
    - Implementation: EmployeeService.cs 