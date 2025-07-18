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
        public MasterContractApplicationContext() { }   
        public DbSet<User> Users { get; set; } 
    }
}
