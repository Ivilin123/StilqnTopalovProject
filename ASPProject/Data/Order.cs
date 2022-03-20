using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPProject.Data
{
    public class Order
    {
        [Key]
        public string UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AmountOrdered { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceOrdered { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
