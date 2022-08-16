using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Enitity
{
    public class DatabaseCoreContext:DbContext
    {
        public DatabaseCoreContext()
        {

        }
        public DatabaseCoreContext(DbContextOptions<DatabaseCoreContext>) { }
    }
}
