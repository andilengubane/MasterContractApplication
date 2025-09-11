using System.ComponentModel.DataAnnotations;

namespace MasterContractApplication.Domain.Entities
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string RoleName { get; set; } = string.Empty;
        [Required]
        public string RoleDescription { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModfyDate { get; set; }
    }
}