using Microsoft.EntityFrameworkCore;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DLLs
{
    public  static class Class1
    {
        static Class1()
        {
            string url = "Hello";
            HttpClient client = new HttpClient();
            var str = client.GetStringAsync(url);
        }
    }

    public class Test : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            InMemoryDbContextOptionsExtensions.UseInMemoryDatabase(optionsBuilder);
        }

        public DbSet<string> Strings { get; set; }
    }
}
