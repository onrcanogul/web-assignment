using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.Application.Abstraction.Classroom;
using Template.Application.Abstraction.Classroom.Dto;
using Template.WebAPI.Controllers.Base;

namespace Template.WebAPI.Controllers.Classroom;

public class ClassroomController(IClassroomService service) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
        => ApiResult(await service.GetListAsync(includeProperties: i => i.Include(x => x.Courses).ThenInclude(x => x.Students)));

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
        => ApiResult(await service.GetFirstOrDefaultAsync(x => x.Id == id, includeProperties: i => i.Include(x => x.Courses).ThenInclude(x => x.Students)));
    
    [HttpPost]
    public async Task<IActionResult> Create(ClassroomDto classroom)
        => ApiResult(await service.CreateAsync(classroom));
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, ClassroomDto classroom)
        => ApiResult(await service.UpdateAsync(id, classroom));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
        => ApiResult(await service.DeleteAsync(id));
}