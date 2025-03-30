using AutoMapper;
using Microsoft.Extensions.Localization;
using Template.Application.Abstraction.Classroom;
using Template.Application.Abstraction.Classroom.Dto;
using Template.Application.src.Base;
using Template.Persistence.Repository;
using Template.Persistence.UnitOfWork;

namespace Template.Application.Classroom;

public class ClassroomService(
    IRepository<Domain.Entities.Classroom.Classroom> repository,
    IMapper mapper,
    IUnitOfWork unitOfWork,
    IStringLocalizer localize) :
    CrudService<Domain.Entities.Classroom.Classroom, ClassroomDto>(repository, mapper, unitOfWork, localize), 
    IClassroomService
{
    
}