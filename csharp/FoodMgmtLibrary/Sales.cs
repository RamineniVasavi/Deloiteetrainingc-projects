using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace FoodMgmtLibrary
{
    public class Sales
    {
        public static string connectionStr = "Data Source=USBLRRVASAVI1;Initial Catalog=FoodManagementDb;Integrated Security=True";
        public string Insertsales(int salesid,int qua,int price,string date,int fid)
        {

            //connection establishment
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "insert into Sales values('" + salesid + "','" + qua + "','" + price + "','" + date + "','" + fid + "')";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();
            return "inserted";
        }
        public string Updatesales(int salesid, int qua, int price, string date)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "update Sales set Quantity='" + qua + "',price='"+price+"',salesDate='"+date+"' where Salesid=" + salesid + "";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();
            return "updated";
        }
        public string DeleteSales(int sid)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "delete from Sales where Salesid=" + sid + "";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();
            return "deleted";
        }
        public DataTable Selectsales()
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "select * from sales";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader dr = cmd.ExecuteReader();///execute sqlcoommand by using cmd object
            DataTable dt = new DataTable();// row &column format
            dt.Load(dr);//converting dr into table
            conn.Close();
            return dt;
        }
    }
}
