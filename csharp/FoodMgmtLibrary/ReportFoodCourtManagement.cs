using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace FoodMgmtLibrary
{
    public class ReportFoodCourtManagement
    {
        public static string connectionStr = "Data Source=USBLRRVASAVI1;Initial Catalog=FoodManagementDb;Integrated Security=True";
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
        public DataTable Selectsales()
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state open
            string qry = "select* from Sales,FoodData where Sales.Foodid = FoodData.Foodid";
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
