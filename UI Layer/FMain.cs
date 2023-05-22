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

namespace CoffeeShopManageMent.UI_Layer
{
    public partial class FMain : Form
    {
        //LOGIN
        public static bool ENALOG = false;

        public static bool IsLog = false;
        //SIGNUP
        public static bool ENASIG = false;
        //CART
        public static bool ENACART = false;
        //EDIT
        public static bool ENAEDITITEM = false;
        //HELP
        public static bool ENAHELP = false;
        //ABOUT
        public static bool ENAABOUT = false;
        //PRODUCT EDIT
        public static bool ENAEDITPRO = false;
        //INFO
        private static bool ENAINFO = false;
        private int INFOCOUNT = 0;

        //USER
        public static string UserName;
        public static string User;
        public static bool IsAdmin;
        public static string Addr;

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
            //int b = ItemGrid.Columns.Count;
            //ItemGrid.Columns.Insert(b, Buy);
            this.ItemGrid.Columns["Price"].DefaultCellStyle.Format = "0#,0 VND";
            //this.ItemGrid.Columns["GiamGia"].DefaultCellStyle.Format = "0.#'%'";
        }
        private void SETUP()
        {
            Addr = "";
            this.SignUpBut.Visible = false;
            this.SignOutBut.Visible = false;
            this.EditProflieBut.Visible = false;
            this.EditItemBut.Visible = false;
            this.CoffeeBut.Visible = true;
            this.LoginBut.Visible = true;
            this.LoginButton.Text = "Login";
            this.LoginButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            User = "";
            UserName = "";
            Addr = "";
            IsAdmin = false;
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

        private void AboutBut_Click(object sender, EventArgs e)
        {
            ENAABOUT = true;
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
                this.SIGNBUTT.Visible = true;
                this.EDITBUTT.Visible = true;
                this.ToolSIGNBUTT.Visible = false;
                this.ToolLOGINBUTT.Visible = false;
                this.HelpBUTT.Visible = true;
                this.LoginBUTT.Text = UserName;
                this.LoginBUTT.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            if (ENALOG)
            {
                ENALOG = false;
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
            if (ENASIG)
            {
                ENASIG = false;
                SignForm form = new SignForm();
                form.ShowDialog();
            }
            if (ENACART)
            {
                ENACART = false;
                if (!IsAdmin)
                {
                    CartForm form = new CartForm();
                    form.ShowDialog();
                }
                else
                {
                    CartForm2 form = new CartForm2();
                    form.ShowDialog();
                }
            }
            if (ENAEDIT)
            {
                ENAEDIT = false;
                UserForm form = new UserForm();
                form.ShowDialog();
            }
            if (ENAHELP)
            {
                ENAHELP = false;
                if (IsAdmin)
                {
                    Help2Form form = new Help2Form();
                    form.ShowDialog();
                }
                else
                {
                    HelpForm form = new HelpForm();
                    form.ShowDialog();
                }
            }
            if (ENAABOUT)
            {
                ENAABOUT = false;
                AboutFrom form = new AboutFrom();
                form.ShowDialog();
            }
            if (IsAdmin)
            {
                this.Edit2BUTT.Visible = true;
            }
            if (ENAEDITPRO)
            {
                ENAEDITPRO = false;
                EditProForm form = new EditProForm();
                form.ShowDialog();
                Querry.ShowALL(DataGrid);
            }
            if (ENAINFO)
            {
                this.Infolabel.Visible = true;
                INFOCOUNT += 100;
                if (INFOCOUNT == 2000)
                {
                    INFOCOUNT = 0;
                    ENAINFO = false;
                    this.Infolabel.Visible = false;
                }
            }
        }
    }
}
