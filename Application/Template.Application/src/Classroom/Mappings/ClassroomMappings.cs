using AutoMapper;
using Template.Application.Abstraction.Classroom.Dto;

namespace Template.Application.Classroom.Mappings;

public class ClassroomMappings : Profile
{
    public ClassroomMappings()
    {
        CreateMap<Domain.Entities.Classroom.Classroom, ClassroomDto>().ReverseMap();
    }
}