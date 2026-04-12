using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_tool.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=db_locale")
        {
        }
    }
}
