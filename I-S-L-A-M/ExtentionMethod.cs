using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_S_L_A_M
{
    internal static class ExtentionMethod
    {
        #region validation Inputs  (͡• ͜ʖ ͡•)  (✿◠‿◠)  ٩(˘◡˘)۶

        public static bool IsValidPhone(this string Phone)
        {
            try
            {
                if (string.IsNullOrEmpty(Phone))
                    return false;
                var r = new Regex(@"^(01)(0|1|2|5)[0-9]{8}$");
                return r.IsMatch(Phone);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool IsValidEmail(this string Email)
        {
            try
            {
                if (string.IsNullOrEmpty(Email))
                    return false;
                var r = new Regex(@"^([a-z]|[A-Z]|[0-1000000]).*(@)([a-z]).*(.)(com)$");
                return r.IsMatch(Email);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool IsValidString(this string strin)
        {
            try
            {
                if (string.IsNullOrEmpty(strin))
                    return false;
                var r = new Regex(@"^[\u0600-\u06ff]|[\u0750-\u077f]|[\ufb50-\ufc3f]|[\ufe70-\ufefc]*$");
                return r.IsMatch(strin);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool IsValidNum(this string num)
        {
            try
            {
                if (string.IsNullOrEmpty(num))
                    return false;
                var r = new Regex(@"^[0-9]*$");
                return r.IsMatch(num);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion validation Inputs  (͡• ͜ʖ ͡•)  (✿◠‿◠)  ٩(˘◡˘)۶

        #region ( ◑‿◑)ɔ┏🍟--🍔┑٩(^◡^ )

        public static void StyleDatagridview(this DataGridView dataGridView1)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Monolisa", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        #endregion ( ◑‿◑)ɔ┏🍟--🍔┑٩(^◡^ )

        public static void QueryDataSource<T>(this DataGridView dataGridView1, IQueryable<T> Query)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Query.ToList();
        }

        public static IQueryable<Category> CategoryQ(this Context context)
        {
            var CategoryQuery = from d in context.Categories
                                select d;
            return CategoryQuery;
        }

        public static IQueryable<Store> BranchQ(this Context context)
        {
            var brnch = from d in context.Stores
                        select d;
            return brnch;
        }

        public static IQueryable<Customer> CustomerQ(this Context context)
        {
            var Q1 = from d in context.Customers
                     select d;
            return Q1;
        }

        public static IQueryable<Supplier> SupplierQ(this Context context)
        {
            var Q1 = from s in context.Suppliers
                     select s;
            return Q1;
        }

        public static IQueryable<Vendor> VendorQ(this Context context)
        {
            var Q2 = from v in context.Vendors
                     select v;
            return Q2;
        }

        public static IQueryable<Product> ProductQ(this Context context, int ID)
        {
            var prod = from p in context.Products
                       where p.Cat_id == ID
                       select p;
            return prod;
        }
    }
}