using Microsoft.EntityFrameworkCore;
using RubicX_server.DataAccess.Core.Interfaces.DbContext;
using RubicX_server.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_server.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext , IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base (options)
        {
            
        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
