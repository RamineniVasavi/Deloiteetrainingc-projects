using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FoodMgmtLibrary
{
    public class FoodDbConnection
    {

        public static string connectionStr = "Data Source=USBLRRVASAVI1;Initial Catalog=FoodManagementDb;Integrated Security=True";
        public string InsertFoodItem(int foodid,int cid,string foodname,string fooddesc)
        {
            #region connectedmode
            /*   //connection establishment
               SqlConnection conn = new SqlConnection(connectionStr);
               conn.Open();//connection state open
               string qry = "insert into FoodData values('"+foodname+"','"+fooddesc+"')";
               //passing sql query with connection object
               SqlCommand cmd = new SqlCommand(qry, conn);
               int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
               conn.Close();
            */
            #endregion
            #region disconnectedmode
            //connection establishment
            SqlConnection conn = new SqlConnection(connectionStr);
            //conn.Open();//connection state open
            string qry = "insert into FoodData values('" + foodid + "','" + foodname + "','" + fooddesc + "','" + cid + "')";
            //passing sql query with connection object
            SqlDataAdapter adp = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            //conn.Close();
            #endregion
            return "Inserted";
        }
        public string UpdateFoodItem(int Foodid,string foodname, string fooddesc)
        {

            //connection establishment
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "update FoodData set Foodname='" + foodname + "',Fooddesc='" + fooddesc + "' where Foodid="+Foodid+"";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();

            return "Updated";
        }
        public string DeletedFoodItem(int Foodid)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "delete from FoodData where Foodid="+ Foodid+"";
            //passing sql query with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();///execute sqlcoommand by using cmd object
            conn.Close();

            return "DELETED";
        }
        public DataTable SelectFoodItem()
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "select * from FoodData";
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
