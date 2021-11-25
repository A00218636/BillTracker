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
        int InvoiceNumber { get; set; }

        int TerminanlID { get; set; }

        string ProcessedBy { get; set; }

        Product Product { get; set; }

        string ProdDesc { get; set; }

        double SellingPrice { get; set; }

        DateTime InvcDateTime { get; set; }

        List<ItemList> provinceList = new List<ItemList>()
        {
        new ItemList { Text = "Alberta", Value = 1 },
        new ItemList { Text = "BC", Value = 2 },
        new ItemList { Text = "Manitoba", Value = 3 },
        new ItemList { Text = "NB", Value = 4 },
        new ItemList { Text = "Ontario", Value = 5 },
        };



        double GST { get; set; }

        double HST { get; set; }

        double PST { get; set; }

        double TotalTax { get; set; }

        string Notes { get; set; }

        double SubTotal { get; set; }

        double Total { get; set; }

        int GSTHSTRefNo { get; set; }

        string CustomerInstructions { get; set; }
    }
}
