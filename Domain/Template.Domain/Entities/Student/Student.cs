using Template.Common.Models.Entities;

namespace Template.Domain.Entities.Student;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Course.Course> Courses { get; set; } = new();
}