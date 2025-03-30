using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.Application.Abstraction.Course;
using Template.Application.Abstraction.Course.Dto;
using Template.WebAPI.Controllers.Base;

namespace Template.WebAPI.Controllers.Course;

public class CourseController(ICourseService service) : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
        => ApiResult(await service.GetListAsync(includeProperties: i => i.Include(x => x.Classroom).Include(x => x.Students)));

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
        => ApiResult(await service.GetFirstOrDefaultAsync(x => x.Id == id, includeProperties: i => i.Include(x => x.Classroom).Include(x => x.Students)));
    
    [HttpPost]
    public async Task<IActionResult> Create(CourseDto course)
        => ApiResult(await service.CreateAsync(course));
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, CourseDto course)
        => ApiResult(await service.UpdateAsync(id, course));
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
        => ApiResult(await service.DeleteAsync(id));
}