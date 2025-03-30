using Template.Application.Abstraction.Classroom.Dto;
using Template.Common.Models.Dtos;

namespace Template.Application.Abstraction.Course.Dto;

public class CourseDto : BaseDto
{
    public string Title { get; set; }
    public Guid ClassroomId { get; set; }
    public ClassroomDto? Classroom { get; set; }
    public List<Domain.Entities.Student.Student> Students { get; set; } = new();
}