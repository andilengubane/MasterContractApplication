using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterContractApplication.Domain.Entities
{
    public class BankDetails
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string BankName { get; set; } = string.Empty;
        [Required]
        public string BranchCode { get; set; } = string.Empty;
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool Batch { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
        public BankDetails bankDetails { get; set; } = new BankDetails();
        [ForeignKey("BankDetails")]
        public int BankDetailsId { get; set; }
    }

}