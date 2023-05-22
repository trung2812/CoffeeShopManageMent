using CoffeeShopManageMent.Connects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManageMent.BSLayer
{
    public class BLItem
    {
        string err;
        public BLItem() { }
        public void ShowALL(DataGridView DataGrid)
        {
            DataTable dtItem = new DataTable();
            dtItem.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from Item", CommandType.Text);
            dtItem = a.Tables[0];
            DataGrid.DataSource = dtItem;
        }
        public void ShowSP(DataGridView DataGrid, string SP)
        {
            DataTable dtItem = new DataTable();
            dtItem.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet("select * from " + SP, CommandType.Text);
            dtItem = a.Tables[0];
            DataGrid.DataSource = dtItem;
        }
        public void FindItem(DataGridView DataGrid, string SP)
        {
            DataTable dtItem = new DataTable();
            dtItem.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"SELECT * FROM dbo.GetSpecificItems('{SP}', '{SP}' );", CommandType.Text);
            dtItem = a.Tables[0];
            DataGrid.DataSource = dtItem;
        }
        public void UpdateItem(string itemId, string newItemName, decimal newPrice, string newItemTypeId)
        {
            using (SqlConnection connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("proc_UpdateItem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Item_Id", itemId);
                    command.Parameters.AddWithValue("@New_Item_Name", newItemName);
                    command.Parameters.AddWithValue("@New_Price", newPrice);
                    command.Parameters.AddWithValue("@New_ItemType_Id", newItemTypeId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
