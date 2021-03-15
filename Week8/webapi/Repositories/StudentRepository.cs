using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Database;
using System;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _dbContext;

    private readonly ILogger _logger;


    // public StudentController(SchoolContext dbContext)
    // {
    //     _dbContext = dbContext;
    //     // _logger = logger;
    // }

    public StudentRepository(SchoolContext dbContext, ILoggerFactory loggerFactory)
    {
        _dbContext = dbContext;
        _logger = loggerFactory.CreateLogger("Controllers.ProductRepository");
    }

    public List<Student> GetAllStudents()
    {
        try
        {
            return _dbContext.Student.ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to get products.", ex);

            return new List<Student>();
        }
    }

    public Student GetStudentById(long studentId)
    {
        return _dbContext.Student
                .SingleOrDefault(p => p.StudentId == studentId);
    }
}