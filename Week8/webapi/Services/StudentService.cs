using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;
    private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRespository, ILoggerFactory loggerFactory)
    {
        _studentRespository = studentRespository;
        _logger = loggerFactory.CreateLogger("Controllers.ProductService");
    }

    public List<StudentModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentModel>();

        foreach (var student in _studentRespository.GetAllStudents())
        {
            studentViewModels.Add(new StudentModel
            {
                StudentId = student.StudentId,
                Email = student.Email,
                Special = student.Special,
            });
            if (BusinessRules.isSpecial(student))
            {
                _logger.LogInformation("This student is special: " + student.StudentId);
            }
        }

        return studentViewModels;
    }

    public StudentModel GetStudentById(long studentId)
    {
        var student = _studentRespository.GetStudentById(studentId);

        return new StudentModel
        {
            StudentId = student.StudentId,
            Email = student.Email,
            Special = student.Special,
            // IsSpecial = BusinessRules.isSpecial(student),
            // LowInventory = BusinessRules.isLowInventory(product)
        };
    }
}