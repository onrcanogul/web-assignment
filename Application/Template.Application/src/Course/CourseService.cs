using AutoMapper;
using Microsoft.Extensions.Localization;
using Template.Application.Abstraction.Course;
using Template.Application.Abstraction.Course.Dto;
using Template.Application.src.Base;
using Template.Persistence.Repository;
using Template.Persistence.UnitOfWork;

namespace Template.Application.Course;

public class CourseService(
    IRepository<Domain.Entities.Course.Course> repository,
    IMapper mapper,
    IUnitOfWork unitOfWork,
    IStringLocalizer localize) : 
    CrudService<Domain.Entities.Course.Course, CourseDto>(repository, mapper, unitOfWork, localize), 
    ICourseService
{
    
}