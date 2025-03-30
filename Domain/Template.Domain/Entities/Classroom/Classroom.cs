using Template.Common.Models.Entities;

namespace Template.Domain.Entities.Classroom;

public class Classroom : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public List<Course.Course> Courses { get; set; } = new();
}