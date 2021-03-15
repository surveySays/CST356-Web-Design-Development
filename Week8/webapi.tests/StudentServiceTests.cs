using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock
    // private const string OnSaleKey = "b";
    // private const int LowInventoryCount = 3;

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository, loggerFactory);
    }

    [Test]
    public void ShouldNotReturnSpecialStudents()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    Email = "email@email",
                    StudentId = 548496494,
                    Special = true,
                },
                new Student {
                    Email = "email@email",
                    StudentId = 998888899,
                    Special = true
                },
                new Student {
                    Email = "email@email",
                    StudentId = 55555555555,
                    Special = true
                },
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(pdto => pdto.Special), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(pdto => pdto.Special).Should().BeTrue();
    }

    [Test]
    public void ShouldReturnNoneSpeicalStudents()
    {
        // Arrange
        // var expectedProductName = OnSaleKey + "test";

        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    Email = "email@email",
                    StudentId = 548496494,
                    Special = false,
                },
                new Student {
                    Email = "email@email",
                    StudentId = 998888899,
                    Special = false
                },
                new Student {
                    Email = "email@email",
                    StudentId = 55555555555,
                    Special = false
                },
            }
        );

        // Act
        var studentViewModels = _studentService.GetAllStudents();
        //Assert
        Assert.That(studentViewModels.Any(pdto => pdto.Special), Is.EqualTo(false));

        studentViewModels.Any(pdto => pdto.Special).Should().BeFalse();
        // Assert (FluentAssertions)
        // studentViewModels.Count(pdto => pdto.Special).Should().False();
        // studentViewModels.Single(pdto => pdto.OnSale).Name.Should().Be(expectedProductName);
    }

}