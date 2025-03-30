using AutoMapper;
using Microsoft.Extensions.Localization;
using Template.Application.Abstraction.Student;
using Template.Application.Abstraction.Student.Dto;
using Template.Application.src.Base;
using Template.Persistence.Repository;
using Template.Persistence.UnitOfWork;

namespace Template.Application.Student;

public class StudentService(
    IRepository<Domain.Entities.Student.Student> repository,
    IMapper mapper,
    IUnitOfWork unitOfWork,
    IStringLocalizer localize) :
    CrudService<Domain.Entities.Student.Student, StudentDto>(repository, mapper, unitOfWork, localize),
    IStudentService
{
    
}