using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FisrtName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string RegNumber { get; set; } = string.Empty;
        public bool IsActived { get; set; } 
        public int UserRole { get; set; }

        public User(string FisrtName, string LastName, string EmailAddress, string Password, string RegNumber, bool IsActived, int UserRole)
        { 
        
        }

        public  void UpdateUser(string FisrtName, string LastName, string EmailAddress, string Password, string RegNumber, bool IsActived, int UserRole)
        { 
        
        }
    }
}
