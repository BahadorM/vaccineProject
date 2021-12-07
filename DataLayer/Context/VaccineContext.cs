using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
    public class VaccineContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Turn> Turns { get; set; }
        public DbSet<States> States { get; set; }
        
    }
}
