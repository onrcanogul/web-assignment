using AutoMapper;
using Template.Application.Abstraction.Course.Dto;

namespace Template.Application.Course.Mappings;

public class CourseMappings : Profile
{
    public CourseMappings()
    {
        CreateMap<Domain.Entities.Course.Course, CourseDto>().ReverseMap();
    }
}