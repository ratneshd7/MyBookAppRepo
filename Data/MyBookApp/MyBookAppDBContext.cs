using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyBookApp
{
    public class MyBookAppDBContext : DbContext
    {
        public MyBookAppDBContext(DbContextOptions<MyBookAppDBContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
