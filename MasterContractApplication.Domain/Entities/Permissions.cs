using System.ComponentModel.DataAnnotations;

namespace MasterContractApplication.Domain.Entities
{
    public class Permissions
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public Nullable<System.DateTime> Createddate { get; set; }
        public bool IsActive { get; set; }
    }
}
