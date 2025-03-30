using Template.Application.Abstraction.Course.Dto;
using Template.Application.src.Abstraction.Base;

namespace Template.Application.Abstraction.Course;

public interface ICourseService : ICrudService<Domain.Entities.Course.Course, CourseDto>
{
    
}