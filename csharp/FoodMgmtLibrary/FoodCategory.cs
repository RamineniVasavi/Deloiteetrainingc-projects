using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FoodMgmtLibrary
{
    public class FoodCategory
    {
        public static string connectionStr = "Data Source=USBLRRVASAVI1;Initial Catalog=FoodManagementDb;Integrated Security=True";
        public string InsertFoodCategory(int cid, string foodcate)
        {
            
            //connection establishment
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "insert into Category values('" + cid + "','" + foodcate + "')";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();
            return "inserted";
        }
        public string UpdateFoodCategory(int cid,string foodcate)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "update Category set Cname='" + foodcate + "' where Cid=" + cid + "";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();
            return "updated";
        }
        public string DeleteFoodCategory(int cid)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "delete from Category where Cid=" + cid + "";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();
            return "deleted";
        }
        public DataTable SelectCategory()
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "select * from Category";
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
