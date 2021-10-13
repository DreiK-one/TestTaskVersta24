using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.EF
{
    public class TestTaskContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public TestTaskContext(DbContextOptions<TestTaskContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
