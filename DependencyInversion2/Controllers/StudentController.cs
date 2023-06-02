using DependencyInversion.Models;
using DependencyInversion.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    ILogBook logbook;

    IStudentRepository studentRepository;

    public StudentController(ILogBook logbook, IStudentRepository studentRepository)
    {
        this.logbook = logbook;
        this.studentRepository = studentRepository;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
