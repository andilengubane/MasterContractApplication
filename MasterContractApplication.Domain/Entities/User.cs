using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FisrtName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string RegNumber { get; set; } = string.Empty;
        public bool IsActived { get; set; }
        [ForeignKey("Role")]
        public Guid UserRoleId { get; set; }
        public virtual Role Role { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
