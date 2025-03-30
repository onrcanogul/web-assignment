using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.Application.Abstraction.Student;
using Template.Application.Abstraction.Student.Dto;
using Template.WebAPI.Controllers.Base;

namespace Template.WebAPI.Controllers.Student;

public class StudentController(IStudentService service) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
        => ApiResult(await service.GetListAsync(includeProperties: i => i.Include(x => x.Courses).ThenInclude(x => x.Classroom)));

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
        => ApiResult(await service.GetFirstOrDefaultAsync(x => x.Id == id, includeProperties: i => i.Include(x => x.Courses).ThenInclude(x => x.Classroom)));
    
    [HttpPost]
    public async Task<IActionResult> Create(StudentDto student)
        => ApiResult(await service.CreateAsync(student));
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, StudentDto student)
        => ApiResult(await service.UpdateAsync(id, student));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
        => ApiResult(await service.DeleteAsync(id));
}