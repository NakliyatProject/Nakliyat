using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Context;

namespace Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NakliyatDbContext>
    {
        public NakliyatDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<NakliyatDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
