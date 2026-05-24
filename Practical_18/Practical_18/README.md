# Practical 18

Controllers:
- StudentsController
- StudentsApiController

Action Methods:
- Index
- Details
- Create [GET]
- Create [POST]
- Edit [GET]
- Edit [POST]
- Delete [GET]
- DeleteConfirmed [POST]
- GetStudents [GET]
- GetStudent [GET]
- CreateStudent [POST]
- UpdateStudent [PUT]
- DeleteStudent [DELETE]

Views:
- Views/Students/Index.cshtml
- Views/Students/Create.cshtml
- Views/Students/Edit.cshtml
- Views/Students/Details.cshtml
- Views/Students/Delete.cshtml

Models:
- Entity:
    - Student
- ViewModel:
    - StudentViewModel
- AutoMapper configuration:
    - MappingProfile.cs
- EF Core DbContext:
    - ApplicationDbContext.cs
- Validation:
    - Validators/StudentValidator.cs
