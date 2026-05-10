using Microsoft.AspNetCore.Mvc;
using Practical_17.Models.Entities;
using Practical_17.Services.Interfaces;

namespace Practical_17.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentsController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetStudents()
    {
        return Ok(_service.GetAllStudents());
    }

    [HttpGet("{id}")]
    public IActionResult GetStudent(int id)
    {
        var student = _service.GetStudentById(id);

        if (student == null)
            return NotFound();

        return Ok(student);
    }

    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        _service.AddStudent(student);
        return Ok(student);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudent(int id, Student student)
    {
        if (id != student.Id)
            return BadRequest();

        _service.UpdateStudent(student);
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        _service.DeleteStudent(id);
        return Ok();
    }
}