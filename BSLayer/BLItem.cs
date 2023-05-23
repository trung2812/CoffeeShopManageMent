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
        public void UpdateItem(DataGridView DataGrid, string itemId, string newItemName, int newPrice, string newItemTypeId)
        {
            DataTable dtItem = new DataTable();
            dtItem.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"exec dbo.proc_UpdateItem '{itemId}', '{newItemName}','{newPrice}','{newItemTypeId}' ", CommandType.Text);
            dtItem = a.Tables[0];
            DataGrid.DataSource = dtItem;
        }
        public void InsertItem(DataGridView DataGrid, string itemId, string newItemName, int newPrice, string newItemTypeId)
        {
            DataTable dtItem = new DataTable();
            dtItem.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"exec dbo.proc_InsertItem '{itemId}', '{newItemName}','{newPrice}','{newItemTypeId}' ", CommandType.Text);
            dtItem = a.Tables[0];
            DataGrid.DataSource = dtItem;
        }
        public void DeleteItem( string itemId)
        {
            DataTable dtItem = new DataTable();
            dtItem.Clear();
            DBMain db = new DBMain();
            DataSet a = db.ExecuteQueryDataSet($"exec dbo.DeleteItem '{itemId}'", CommandType.Text);

        }
    }
}
