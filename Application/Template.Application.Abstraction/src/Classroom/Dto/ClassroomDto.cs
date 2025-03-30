using Template.Application.Abstraction.Course.Dto;
using Template.Common.Models.Dtos;

namespace Template.Application.Abstraction.Classroom.Dto;

public class ClassroomDto : BaseDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public List<CourseDto> Courses { get; set; } = new();
}