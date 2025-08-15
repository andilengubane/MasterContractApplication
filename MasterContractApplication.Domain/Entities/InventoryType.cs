using System.ComponentModel.DataAnnotations;

namespace MasterContractApplication.Domain.Entities
{
    public class InventoryType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string InventoryTypeName { get; set; } = string.Empty;
        [Required]
        public string InventoryTypeDescription { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        [Required]
        public DateTime DateLogged { get; set; }
    }
}
