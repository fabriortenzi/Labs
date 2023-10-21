using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}
