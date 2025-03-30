using Template.Application.Abstraction.Course.Dto;
using Template.Common.Models.Dtos;

namespace Template.Application.Abstraction.Student.Dto;

public class StudentDto : BaseDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<CourseDto> Courses { get; set; } = new();
}