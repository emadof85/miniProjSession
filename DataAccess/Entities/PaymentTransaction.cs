using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public enum TType
    {
        Deposit,
        Final,
        Refund
    }
    public partial class PaymentTransaction
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        [EnumDataType(typeof(TType))]
        public TType TransactionType { get; set; }

        [Required]
        [Column("amount", TypeName = "decimal(16,2)")]
        public decimal Amount { get; set; }

        [Required]
        [Column("transactionDate", TypeName = "datetime2(7)")]
        public DateTime TransactionDate { get; set; }

        [Column("paymentId")]
        public Payment? Payment { get; set; }

        [Column("paymentMethodId")]
        public PaymentMethod? PaymentMethod { get; set; }
    }
}
