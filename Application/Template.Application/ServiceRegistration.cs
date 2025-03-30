using Microsoft.Extensions.DependencyInjection;
using Template.Application.Abstraction.Classroom;
using Template.Application.Abstraction.Course;
using Template.Application.Abstraction.src;
using Template.Application.Abstraction.Student;
using Template.Application.Classroom;
using Template.Application.Classroom.Mappings;
using Template.Application.Course;
using Template.Application.src;
using Template.Application.src.Abstraction.Base;
using Template.Application.src.Base;
using Template.Application.Student;

namespace Template.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ClassroomMappings).Assembly);
        services.AddScoped(typeof(ICrudService<,>), typeof(CrudService<,>));
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<IClassroomService, ClassroomService>();
        return services;
    }
}