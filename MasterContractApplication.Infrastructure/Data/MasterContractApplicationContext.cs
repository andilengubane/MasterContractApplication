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
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<AssignInventory> AssignInventorys { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<InventoryType> InventoryTypes { get; set; }
        public DbSet<Inventory> Inventorys { get; set; }
        public DbSet<InventoryDetails> InventoryDetails { get; set; }
    }
}
