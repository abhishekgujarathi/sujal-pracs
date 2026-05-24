# Practical 19

Controllers:
- AccountController
- AuthApiController
- HomeController
- AdminController

Action Methods:
AccountController:
- Register [GET]
- Register [POST]
- Login [GET]
- Login [POST]
- Logout [POST]
- AccessDenied

AuthApiController:
- POST api/authapi/register
- POST api/authapi/login

HomeController:
- Index

AdminController:
- Index

Views:
- Views/Account/Register.cshtml
- Views/Account/Login.cshtml
- Views/Account/AccessDenied.cshtml
- Views/Home/Index.cshtml
- Views/Admin/Index.cshtml

Models:
- Identity Entity: ApplicationUser
- ViewModels:
  - RegisterViewModel
  - LoginViewModel

Services:
- Interface: IAuthService.cs
- Implementation: AuthService.cs