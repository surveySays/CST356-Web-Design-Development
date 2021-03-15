using System.Collections.Generic;

public interface IStudentRepository
{
    List<Student> GetAllStudents();
    Student GetStudentById(long studentId);

    // void AddProduct(Student student);

    // void UpdateProduct(Student student);

    // void DeleteProduct(long studentId);
}