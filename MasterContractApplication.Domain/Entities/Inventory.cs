using System.ComponentModel.DataAnnotations;

namespace MasterContractApplication.Domain.Entities
{
    public class Inventory
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid InventoryTypeId { get; set; }
        [Required]
        public Guid InventoryStatusId { get; set; }
        [Required]
        public Guid EquipmentStatusId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string SerialNumber { get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
        [Required]
        public string Supplier { get; set; } = string.Empty;
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
    }
}
