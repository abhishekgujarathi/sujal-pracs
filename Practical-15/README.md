# Practical 15

## Test 1: Windows Authentication
Controllers:
- HomeController

Action Methods:  
- Index
- DashBoard

Views:
- Views/Home/Index.cshtml
- Views/Home/DashBoard.cshtml

Attributes:
- [Authorize] on HomeController.DashBoard()

## Test 2: Form Authentication
Controllers:
- AccountController

Action Methods:
- Login [GET]
- Login [POST]
- Register [GET]
- Register [POST]
- Logout [GET]
  
- HomeController

ActionMethods:
- Index()

Views:
- Views/Account/Login.cshtml
- Views/Account/Register.cshtml
- Views/Home/Index.cshtml

Models:
- Entities:
  - User.cs
- Repository:
    - Interface: IUserRepository.cs
    - Implementation: UserRepository.cs 
- Service:
    - Interface: IUserService.cs
    - Implementation: UserService.cs 

Attributes:
- [Authorize] on HomeController.Index()
- [AllowAnonymous] on AccountController.Login()
- [AllowAnonymous] on AccountController.Login(User model)
- [AllowAnonymous] on AccountController.Register()
- [AllowAnonymous] on AccountController.Register(User user)