using MasterContractApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Infrastructure.Data
{
    public class MasterContractApplicationContext : DbContext
    {
        public MasterContractApplicationContext(DbContextOptions<MasterContractApplicationContext> option)
            :base(option) 
        {
        
        }   

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
