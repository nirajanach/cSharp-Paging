using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared;

public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "Data Source=JARVIS\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

        optionsBuilder.UseSqlServer(connection);


        Console.WriteLine($"conection to db succeeded");
    }
}
