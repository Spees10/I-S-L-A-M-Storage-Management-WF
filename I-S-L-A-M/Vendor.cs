using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class Vendor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }
        public string Email { set; get; }
        public string City { set; get; }
        public string Adderss { set; get; }
        public string Phone { set; get; }
        public byte Stars { set; get; }

        public virtual List<VendProdBill> VendProdBills { set; get; }
    }
}