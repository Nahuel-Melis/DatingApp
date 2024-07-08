using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}