using Template.Application.Abstraction.Classroom.Dto;
using Template.Application.src.Abstraction.Base;

namespace Template.Application.Abstraction.Classroom;

public interface IClassroomService : ICrudService<Domain.Entities.Classroom.Classroom, ClassroomDto>
{
}