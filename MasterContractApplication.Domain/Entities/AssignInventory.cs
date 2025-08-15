using System.ComponentModel.DataAnnotations;

namespace MasterContractApplication.Domain.Entities
{
    public class AssignInventory
    {
        public Guid Id { get; set; }
        public Guid CostCenterId { get; set; }
        [Required]
        public Guid InventoryId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid InventoryTypeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateLogged { get; set; }
    }
}
