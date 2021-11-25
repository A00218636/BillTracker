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
        string ID { get; set; }

        string Description { get; set; }

        Category ProdCategory { get; set; }

        private class Category
        {
            [Key]
            string ID { get; set; }
            string Description { get; set; }
        }

       double Discount { get; set; }


    }
}
