using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class Propertiess
    {
        static List<Propertiess> list = new List<Propertiess>();
        public int itemID { get; set; }
        public string datee { get; set; }
        public int inventnum { get; set; }
        public string objectName { get; set; }
        public int count { get; set; }
        public int price { get; set; }

        public bool isAvailable { get; set; }

        public void save()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DARIKS-PC\\SQLEXPRESS; Database= modelclass; Integrated security = True;");
            try
            {
                SqlCommand cmd = new SqlCommand("insertintoinvent)", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemid", itemID);

                cmd.Parameters.AddWithValue("@invnumber", inventnum);
                cmd.Parameters.AddWithValue("@objectname", objectName);
                cmd.Parameters.AddWithValue("@countt", count);
                cmd.Parameters.AddWithValue("@price", price);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }

        }
         public static List<Propertiess> getallprop()
        {
            Propertiess p = new Propertiess();
            List<Propertiess> temp = new List<Propertiess>();
            SqlConnection con = new SqlConnection(@"Data Source=DARIKS-PC\\SQLEXPRESS; Database= modelclass;Integrated security = true;");
            SqlCommand cmd = new SqlCommand("displayall", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                p.itemID = (int)result[0];
                p.inventnum = (int)result[1];
                p.objectName = (string)result[2];
                p.count = (int)result[3];
                p.price = (int)result[4];
            }
            temp.Add(p);

            return temp;
        }
    }







    } 

