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

        protected static void ModelBuilder(ModelBuilder modelBuilder)
        {
            //(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        }
    }
}
