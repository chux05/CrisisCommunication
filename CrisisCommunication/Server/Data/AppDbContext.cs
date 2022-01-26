using CrisisCommunication.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrisisCommunication.Server.Data
{
    public class AppDbContext: DbContext
    {
        private AppDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<User> Users { get; set; }
    }
}
