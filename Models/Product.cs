using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BillTracker.Models
{
    public class Product
    {
        [Key]
        public string ID { get; set; }

        public string Description { get; set; }

        public Category ProdCategory { get; set; }

        public class Category
        {
            [Key]
            public string ID { get; set; }
            public string Description { get; set; }
        }

        public double Discount { get; set; }

        


    }
}
