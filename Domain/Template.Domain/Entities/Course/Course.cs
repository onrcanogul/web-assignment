using Template.Common.Models.Entities;

namespace Template.Domain.Entities.Course;

public class Course : BaseEntity
{
    public string Title { get; set; }
    public Guid ClassroomId { get; set; }
    public Classroom.Classroom Classroom { get; set; } = new();
    public List<Student.Student> Students { get; set; } = new();
}