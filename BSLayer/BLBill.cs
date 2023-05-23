using CoffeeShopManageMent.Connects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManageMent.DataLayers
{
    public class BLBill
    {
        public BLBill() { }
        SqlConnection conn = new SqlConnection("Data Source=MYPC\\QUOCTRUNG;" + "Initial Catalog=CafeManagementSystem;" + "Integrated Security=SSPI;");
        public void ShowALLBill(DataGridView DataGrid)
        {
            DataTable dtBill = new DataTable();
            dtBill.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from Bill", CommandType.Text);
            dtBill = a.Tables[0];
            DataGrid.DataSource = dtBill;
        }
        public void ShowALLBillDetails(DataGridView DataGrid)
        {
            DataTable dtBill = new DataTable();
            dtBill.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from BillDetails", CommandType.Text);
            dtBill = a.Tables[0];
            DataGrid.DataSource = dtBill;
        }
        public void InsertBill(string bill_id, string customer_id, string staff_id, string table_id)
        {
            SqlCommand cmd = new SqlCommand("proc_InsertBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Bill_Id", bill_id);
            cmd.Parameters.AddWithValue("@Customer_Id", customer_id);
            cmd.Parameters.AddWithValue("@Staff_id", staff_id);
            cmd.Parameters.AddWithValue("@Table_Id", table_id);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
        public void UpdateBill(string bill_id, string new_customer_id, string new_staff_id, string new_table_id)
        {
            SqlCommand cmd = new SqlCommand("proc_UpdateBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Bill_Id", bill_id);
            cmd.Parameters.AddWithValue("@New_Customer_Id", new_customer_id);
            cmd.Parameters.AddWithValue("@New_Staff_id", new_staff_id);
            cmd.Parameters.AddWithValue("@New_Table_Id", new_table_id);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
        public void DeleteBill(string bill_id)
        {
            SqlCommand cmd = new SqlCommand("proc_UpdatePaidBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Bill_Id", bill_id);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
    }
}
