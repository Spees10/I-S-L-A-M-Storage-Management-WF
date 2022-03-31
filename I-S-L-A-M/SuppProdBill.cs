using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class SuppProdBill
    {
        [Key, ForeignKey("Product")]
        [Column(Order = 1)]
        public int Pro_ID { set; get; }

        [Key, ForeignKey("Supp")]
        [Column(Order = 2)]
        public int Sup_ID { set; get; }

        [Key, ForeignKey("SupplierBill")]
        [Column(Order = 3)]
        public int Sup_Bill_ID { set; get; }

        public decimal Total_Price { set; get; }

        public int Quantity { set; get; }
        public virtual Supplier Supp { get; set; }
        public virtual Product Product { set; get; }
        public virtual SupplierBill SupplierBill { set; get; }
    }
}