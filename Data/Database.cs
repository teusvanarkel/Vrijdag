using Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;
public class Database : DbContext
{
    public DbSet<Person> Persons { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=PERENCAKE\\SQLEXPRESS;Database=Vrijdag;user id=sa;password=123;");
    }
}
