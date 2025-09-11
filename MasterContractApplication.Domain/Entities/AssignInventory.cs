using System.ComponentModel.DataAnnotations;

namespace MasterContractApplication.Domain.Entities
{
    public class AssignInventory
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid InventoryId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateLogged { get; set; }
    }
}
