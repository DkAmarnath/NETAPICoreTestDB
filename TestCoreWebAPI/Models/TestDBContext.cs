using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWebAPI.Models
{
    
    public class TestDBContext : DbContext
    {

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
