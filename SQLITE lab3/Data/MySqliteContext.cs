using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLITE_lab3.Models;

namespace SQLITE_lab3.Data
{
    public class MySqliteContext : DbContext
    {
        public MySqliteContext (DbContextOptions<MySqliteContext> options)
            : base(options)
        {
        }

        public DbSet<SQLITE_lab3.Models.Cars> Cars { get; set; } = default!;
    }
}
