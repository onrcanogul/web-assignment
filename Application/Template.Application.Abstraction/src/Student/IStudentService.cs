using Template.Application.Abstraction.Student.Dto;
using Template.Application.src.Abstraction.Base;

namespace Template.Application.Abstraction.Student;

public interface IStudentService : ICrudService<Domain.Entities.Student.Student, StudentDto>
{
}