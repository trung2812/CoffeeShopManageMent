using CoffeeShopManageMent.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//0545484515
//01
namespace CoffeeShopManageMent.UI_Layer
{
    public partial class FMain : Form
    {
        //LOGIN
        public static bool ENALOG = false;

        public static bool IsLog = false;
        //SIGNUP
        public static bool ENASIG = false;
        //EDIT
        public static bool ENAEDITITEM = false;
        //PRODUCT EDIT
        public static bool ENAEDITPRO = false;
        //INFO
        private static bool ENAINFO = false;
        private int INFOCOUNT = 0;

        //USER
        public static string UserName;
        public static bool IsManager;


        //DATA
        private BLItem Querry = new BLItem();

        public FMain()
        {
            InitializeComponent();
            SETUP();
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            Querry.ShowALL(ItemGrid);
            this.ItemGrid.Columns["Price"].DefaultCellStyle.Format = "0#,0 VND";
        }
        private void SETUP()
        {

            this.SignUpBut.Visible = true;
            this.SignOutBut.Visible = false;
            this.EditProflieBut.Visible = false;
            this.EditItemBut.Visible = false;
            this.CoffeeBut.Visible = true;
            this.LoginBut.Visible = true;
            this.LoginButton.Text = "Login";
            this.LoginButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UserName = "";

            IsManager = false;
        }

        private void CoffeeBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_CoffeeMenu");
        }

        private void CakeBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_CakedMenu");
        }

        private void IceBlendedBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_IceBlendedMenu");
        }

        private void SodaBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_SodaMenu");
        }

        private void SoftDrinkBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_SparklingWaterMenu");
        }

        private void TeaBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_TeaMenu");
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            ENALOG = true;
        }

        private void HomeBut_Click(object sender, EventArgs e)
        {
            Querry.ShowALL(ItemGrid);
        }

        private void SignUpBut_Click(object sender, EventArgs e)
        {
            ENASIG = true;
        }

        private void SignOutBut_Click(object sender, EventArgs e)
        {
            IsLog = false;
            SETUP();
        }

        private void EditItemBut_Click(object sender, EventArgs e)
        {
            ENAEDITITEM = true;
        }

        private void EditProfileBut_Click(object sender, EventArgs e)
        {
            ENAEDITPRO = true;
        }

        private void TableBut_Click(object sender, EventArgs e)
        {
            Querry.ShowSP(ItemGrid, "vw_AvailableTable");
        }

        private void FindBox_TextChange(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FindBox.Text))
            {
                Querry.ShowALL(ItemGrid);
            }
            else
            {
                Querry.FindItem(ItemGrid, this.FindBox.Text);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsLog)
            {
                this.SignOutBut.Visible = true;
                this.SignUpBut.Visible = false;
                this.EditProflieBut.Visible = true;
                this.LoginBut.Visible = false;
                this.LoginButton.Text = UserName;
                this.LoginButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            if (ENALOG)
            {
                ENALOG = false;
                FLogin form = new FLogin();
                form.ShowDialog();
            }
            if (ENASIG)
            {
                ENASIG = false;
                FSignUp form = new FSignUp();
                form.ShowDialog();
            }

            if (ENAEDITPRO)
            {
                ENAEDITPRO = false;
                FUser form = new FUser();
                form.ShowDialog();
            }

            if (IsManager)
            {
                this.EditItemBut.Visible = true;
            }
            if (ENAEDITITEM)
            {
                ENAEDITITEM = false;
                FEditItem form = new FEditItem();
                form.ShowDialog();
                Querry.ShowALL(ItemGrid);
            }
            if (ENAINFO)
            {
                this.InfoLabel.Visible = true;
                INFOCOUNT += 100;
                if (INFOCOUNT == 2000)
                {
                    INFOCOUNT = 0;
                    ENAINFO = false;
                    this.InfoLabel.Visible = false;
                }
            }
        }
    }
}
