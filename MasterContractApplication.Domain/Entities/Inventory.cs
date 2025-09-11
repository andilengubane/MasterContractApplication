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
        public Guid InventoryDetailId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
    }
}
