using Microsoft.EntityFrameworkCore;

namespace CtlbasedTodoApi.Models;

public class TodoContext : DbContext{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options){}
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    public DbSet<Users> Users { get; set; }
}