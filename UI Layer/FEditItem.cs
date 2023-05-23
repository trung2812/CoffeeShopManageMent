using CoffeeShopManageMent.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManageMent.UI_Layer
{
    public partial class FEditItem : Form
    {
        private BLItem sps = new BLItem();
        public FEditItem()
        {
            InitializeComponent();
            sps.ShowALL(EditItemGridView);
            this.EditItemGridView.Columns["Price"].DefaultCellStyle.Format = "0#,0 VND";
        }

        private bool CheckE()
        {
            if (EdIdBox.Text == "")
            {
                MessageBox.Show("vui lòng nhập ID vật phẩm!");
                return false;
            }
            else if (EdNamBox.Text == "")
            {
                MessageBox.Show("vui lòng nhập tên vật phẩm!");
                return false;
            }
            else if (EdPriBox.Text == "")
            {
                MessageBox.Show("vui lòng nhập giá vật phẩm!");
                return false;
            }
            else if (EdTypBox.Text == "")
            {
                MessageBox.Show("vui lòng nhập loại vật phẩm!");
                return false;
            }
            return true;
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sps.DeleteItem(EdIdBox.Text);
                sps.ShowALL(EditItemGridView);
            }
        }

        private void UpdBut_Click(object sender, EventArgs e)
        {
            if (CheckE())
            {
                sps.UpdateItem(EditItemGridView, EdIdBox.Text, EdNamBox.Text, int.Parse(EdPriBox.Text), EdTypBox.Text);
                sps.ShowALL(EditItemGridView);
            }  
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (CheckE())
            {
                sps.InsertItem(EditItemGridView, EdIdBox.Text, EdNamBox.Text, int.Parse(EdPriBox.Text), EdTypBox.Text);
                sps.ShowALL(EditItemGridView);
            }
        }

    }
}
