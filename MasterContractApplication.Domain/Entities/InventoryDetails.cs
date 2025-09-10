using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Entities
{
    public class InventoryDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public Nullable<bool> IsActive { get; set; }
        public bool IsAssigned { get; set; }
        public string Type { get; set; } = string.Empty;
        public Nullable<DateTime> DateLogged { get; set; }
    }
}
