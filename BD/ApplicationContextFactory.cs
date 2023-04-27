using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BD
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseNpgsql(
                $"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=frgx1337");

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}