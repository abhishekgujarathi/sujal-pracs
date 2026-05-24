# Practical-17

Controllers:
- StudentsController
- UsersController

Action Methods:
StudentsController:
- GetStudents
- GetStudent
- AddStudent
- UpdateStudent
- DeleteStudent

UsersController:
- GetUsers

Models:
- Entity:
    - Student
    - User
    - Role

Repository:
- Interface:
    - IStudentRepository.cs
    - IUserRepository.cs
- Implementation:
    - StudentRepository.cs
    - UserRepository.cs

Service:
- Interface:
    - IStudentService.cs
    - IUserService.cs
- Implementation:
    - StudentService.cs
    - UserService.cs

Data:
- AppDbContext.cs
- DbSeeder.cs
- Migrations:
    - 20260510172840_InitialCreate.cs
    - AppDbContextModelSnapshot.cs
