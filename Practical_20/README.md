# Practical-20

Controllers:
- StudentsController

Action Methods:
- Index
- Create [GET]
- Create [POST]
- Edit [GET]
- Edit [POST]
- Delete [GET]
- DeleteConfirmed [POST]
- Details

Views:
- Create.cshtml
- Delete.cshtml
- Details.cshtml
- Edit.cshtml
- Index.cshtml

Models:
- Entity:
    - Student
    - AuditLog
    - ErrorLog
- Repository:
    - Interface: IGenericRepository.cs
    - Implementation: GenericRepository.cs
    - Interface: IUnitOfWork.cs
    - Implementation: UnitOfWork.cs
- Service:
    - Interface: IStudentService.cs
    - Implementation: StudentService.cs
    - Interface: ILoggingService.cs
    - Implementation: LoggingService .cs
- Middleware:
    - ExceptionHandlingMiddleware.cs
