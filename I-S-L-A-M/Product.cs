using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [ForeignKey("CatID")]
        public int Cat_id { set; get; }

        public int Product_code { set; get; }
        public string Name { set; get; }
        public DateTime Production_Date { set; get; }
        public DateTime Expire_Date { set; get; }
        public decimal Price { set; get; }

        public virtual Category CatID { set; get; }
        public virtual List<ProductStore> ProductStores { set; get; }
        public virtual List<CustProdBill> CustBillProds { set; get; }
        public virtual List<SuppProdBill> SuppBillPros { set; get; }
        public virtual List<VendProdBill> VendBillPros { set; get; }
    }
}