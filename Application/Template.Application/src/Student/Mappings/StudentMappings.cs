using AutoMapper;
using Template.Application.Abstraction.Classroom.Dto;
using Template.Application.Abstraction.Course.Dto;
using Template.Application.Abstraction.Student.Dto;

namespace Template.Application.Course.Mappings;

public class StudentMappings : Profile
{
    public StudentMappings()
    {
        CreateMap<Domain.Entities.Student.Student, StudentDto>().ReverseMap();
    }
}