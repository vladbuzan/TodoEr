using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class TodoErContext : DbContext
{
    public TodoErContext(DbContextOptions<TodoErContext> options) : base(options) { }

    public DbSet<ToDo> ToDos { get; set; }
}
