using API.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<UserModel> Users { get; set; } = default!;
}
