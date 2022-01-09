
using DeviceBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceBoard.Data;
public class GraphQLDbContext : DbContext
{
    public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Device> Devices { get; set; }
}
