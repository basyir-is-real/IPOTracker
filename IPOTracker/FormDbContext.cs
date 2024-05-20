using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPOTracker
{
    public class FormDbContext : DbContext
    {
        public FormDbContext() : base("name=MyLocalDbConnectionString") { }
        public DbSet<Stock> Stocks { get; set; }
    }
}
