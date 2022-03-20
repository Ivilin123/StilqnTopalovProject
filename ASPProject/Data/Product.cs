using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPProject.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        public int Size { get; set; }
        public int Amount { get; set; }
        public  string Information{ get; set; }
         public Purpose Purpose { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } 

        public string ImageURL { get; set; }

        public DateTime ProductOn { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
