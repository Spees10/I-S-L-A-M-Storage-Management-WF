using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Frist_Name { set; get; }
        public string Last_Name { set; get; }
        public string Address { set; get; }

        public string Phone { set; get; }
        public virtual List<CustProdBill> CustBillProds { set; get; }
    }
}