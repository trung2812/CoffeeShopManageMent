using CoffeeShopManageMent.DataLayers;
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
    public partial class FLogin : Form
    {
        BLLogin Login = new BLLogin();
        string User;
        string Password;
        public FLogin()
        {
            InitializeComponent();
        }

        private void Check()
        {
            User = this.UserBox.Text;
            Password = this.PasswordBox.Text;
            if (User == "")
            {
                MessageBox.Show("vui lòng nhập tên tài khoản!");
            }
            else if (Password == "")
            {
                MessageBox.Show("vui lòng nhập mật khẩu!");
            }
            else
            {
                if ((bool)Login.CheckAccountVerification(User, Password) == false)
                    MessageBox.Show("Wrong or Not Found");
                else
                {
                    FMain.IsLog = true;
                    this.Dispose();
                }
            }
        }

        private void UserBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }

        private void PassWordBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            FMain.ENASIG = true;
            this.Dispose();
        }

        private void FLoginBut_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void ShowPassCheck_Click(object sender, EventArgs e)
        {
            this.PasswordBox.UseSystemPasswordChar = !this.ShowPassCheck.Checked;
        }
    }
}
