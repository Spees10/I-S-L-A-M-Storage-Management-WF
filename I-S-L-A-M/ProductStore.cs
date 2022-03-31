using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class ProductStore
    {
        [Key, ForeignKey("Product")]
        [Column(Order = 1)]
        public int Pro_ID { set; get; }

        [Key, ForeignKey("Store")]
        [Column(Order = 2)]
        public int Store_ID { set; get; }

        public int Quantity { set; get; }

        public virtual Store Store { set; get; }
        public virtual Product Product { set; get; }
    }
}