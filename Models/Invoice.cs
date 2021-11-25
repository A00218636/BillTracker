using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BillTracker.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceNumber { get; set; }

        public int TerminanlID { get; set; }

        public string ProcessedBy { get; set; }

        public Product Product { get; set; }

        public string ProdDesc { get; set; }

        public double SellingPrice { get; set; }

        public DateTime InvcDateTime { get; set; }

        public List<ItemList> provinceList = new List<ItemList>()
        {
        new ItemList { Text = "Alberta", Value = 1 },
        new ItemList { Text = "BC", Value = 2 },
        new ItemList { Text = "Manitoba", Value = 3 },
        new ItemList { Text = "NB", Value = 4 },
        new ItemList { Text = "Ontario", Value = 5 },
        };



        public double GST { get; set; }

        public double HST { get; set; }

        public double PST { get; set; }

        public double TotalTax { get; set; }

        public string Notes { get; set; }

        public double SubTotal { get; set; }

        public double Total { get; set; }

        public int GSTHSTRefNo { get; set; }

        public string CustomerInstructions { get; set; }
    }
}
