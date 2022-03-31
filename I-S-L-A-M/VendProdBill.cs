using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class VendProdBill
    {
        [Key, ForeignKey("Product")]
        [Column(Order = 1)]
        public int Pro_ID { set; get; }

        [Key, ForeignKey("Vend")]
        [Column(Order = 2)]
        public int Vend_ID { set; get; }

        [Key, ForeignKey("VendorBill")]
        [Column(Order = 3)]
        public int Vend_Bill_ID { set; get; }

        public decimal Total_Price { set; get; }
        public decimal Paid { set; get; }
        public decimal Rest { set; get; }

        public int Quantity { set; get; }
        public virtual Vendor Vend { get; set; }
        public virtual Product Product { set; get; }
        public virtual VendorBILL VendorBill { set; get; }
    }
}