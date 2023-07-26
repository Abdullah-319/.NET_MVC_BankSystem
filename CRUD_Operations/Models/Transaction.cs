using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Operations.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required]
        [MaxLength(12, ErrorMessage ="Max characters 12 only")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required]
        [MaxLength(11, ErrorMessage = "Max characters 11 only")]
        public string SWIFTCode { get; set; }

        [Required]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }


    }
}
