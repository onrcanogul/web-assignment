using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template.Common.Models.Entities;
using Template.Domain.Entities;
using Template.Domain.Entities.Classroom;
using Template.Domain.Entities.Course;
using Template.Domain.Entities.Identity;
using Template.Domain.Entities.Student;

namespace Template.Persistence.Contexts;

public class TemplateDbContext(DbContextOptions<TemplateDbContext> options, IHttpContextAccessor httpContextAccessor) : IdentityDbContext<User,Role,Guid>(options)
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        AuditingEntities();
        return base.SaveChangesAsync(cancellationToken);
    }
    public override int SaveChanges()
    {
        AuditingEntities();
        return base.SaveChanges();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //soft delete
        modelBuilder.Entity<Student>().HasQueryFilter(p => !p.IsDeleted);
        modelBuilder.Entity<Course>().HasQueryFilter(p => !p.IsDeleted);
        modelBuilder.Entity<Classroom>().HasQueryFilter(p => !p.IsDeleted);
    }
    private void AuditingEntities()
    {
        var dataList = ChangeTracker.Entries<BaseEntity>().ToList();

        foreach (var data in dataList)
        {
            var baseEntity = data.Entity;
            switch (data.State)
            {
                case EntityState.Modified:
                    baseEntity.UpdatedDate = DateTime.UtcNow;
                    baseEntity.UpdatedBy = "onurcan ogul || furkan recber";
                    break;
                case EntityState.Added:
                    baseEntity.CreatedDate = DateTime.UtcNow;
                    baseEntity.UpdatedDate = DateTime.UtcNow;
                    baseEntity.CreatedBy = "onurcan ogul || furkan recber";
                    break;
            }
        }
    }
    private string? GetCurrentUsername()
        => httpContextAccessor.HttpContext?.User.Identity!.Name;
}