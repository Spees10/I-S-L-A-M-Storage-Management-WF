using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class CustProdBill
    {
        [Key, ForeignKey("Product")]
        [Column(Order = 1)]
        public int Pro_ID { set; get; }

        [Key, ForeignKey("Customer")]
        [Column(Order = 2)]
        public int Cust_ID { set; get; }

        [Key, ForeignKey("CustomerBill")]
        [Column(Order = 3)]
        public int Cust_Bill_ID { set; get; }

        public float Total_Price { set; get; }

        public int Quantity { set; get; }
        public virtual Product Product { set; get; }
        public virtual Customer Customer { set; get; }
        public virtual CustomerBILL CustomerBill { set; get; }
    }
}