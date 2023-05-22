namespace CoffeeShopManageMent.UI_Layer
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HomeBut = new System.Windows.Forms.ToolStripButton();
            this.ItemBut = new System.Windows.Forms.ToolStripDropDownButton();
            this.CoffeeBut = new System.Windows.Forms.ToolStripMenuItem();
            this.CakeBut = new System.Windows.Forms.ToolStripMenuItem();
            this.IceBlendedBut = new System.Windows.Forms.ToolStripMenuItem();
            this.SodaBut = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftDrinkBut = new System.Windows.Forms.ToolStripMenuItem();
            this.TeaBut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItemBut = new System.Windows.Forms.ToolStripButton();
            this.AboutBut = new System.Windows.Forms.ToolStripButton();
            this.LoginButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.LoginBut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProflieBut = new System.Windows.Forms.ToolStripMenuItem();
            this.SignUpBut = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOutBut = new System.Windows.Forms.ToolStripMenuItem();
            this.FindBox = new System.Windows.Forms.ToolStripTextBox();
            this.TableBut = new System.Windows.Forms.ToolStripButton();
            this.ShopNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.Location = new System.Drawing.Point(1, 69);
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.RowHeadersWidth = 51;
            this.ItemGrid.RowTemplate.Height = 24;
            this.ItemGrid.Size = new System.Drawing.Size(1277, 577);
            this.ItemGrid.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeBut,
            this.ItemBut,
            this.EditItemBut,
            this.AboutBut,
            this.LoginButton,
            this.FindBox,
            this.TableBut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1279, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HomeBut
            // 
            this.HomeBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HomeBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBut.Image = ((System.Drawing.Image)(resources.GetObject("HomeBut.Image")));
            this.HomeBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeBut.Name = "HomeBut";
            this.HomeBut.Size = new System.Drawing.Size(65, 29);
            this.HomeBut.Text = "Home";
            this.HomeBut.Click += new System.EventHandler(this.HomeBut_Click);
            // 
            // ItemBut
            // 
            this.ItemBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItemBut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoffeeBut,
            this.CakeBut,
            this.IceBlendedBut,
            this.SodaBut,
            this.SoftDrinkBut,
            this.TeaBut});
            this.ItemBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBut.Image = ((System.Drawing.Image)(resources.GetObject("ItemBut.Image")));
            this.ItemBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemBut.Name = "ItemBut";
            this.ItemBut.Size = new System.Drawing.Size(135, 29);
            this.ItemBut.Text = "Drinks / Food";
            // 
            // CoffeeBut
            // 
            this.CoffeeBut.Name = "CoffeeBut";
            this.CoffeeBut.Size = new System.Drawing.Size(189, 30);
            this.CoffeeBut.Text = "Coffee";
            this.CoffeeBut.Click += new System.EventHandler(this.CoffeeBut_Click);
            // 
            // CakeBut
            // 
            this.CakeBut.Name = "CakeBut";
            this.CakeBut.Size = new System.Drawing.Size(189, 30);
            this.CakeBut.Text = "Cake";
            this.CakeBut.Click += new System.EventHandler(this.CakeBut_Click);
            // 
            // IceBlendedBut
            // 
            this.IceBlendedBut.Name = "IceBlendedBut";
            this.IceBlendedBut.Size = new System.Drawing.Size(189, 30);
            this.IceBlendedBut.Text = "Ice Blended";
            this.IceBlendedBut.Click += new System.EventHandler(this.IceBlendedBut_Click);
            // 
            // SodaBut
            // 
            this.SodaBut.Name = "SodaBut";
            this.SodaBut.Size = new System.Drawing.Size(189, 30);
            this.SodaBut.Text = "Soda";
            this.SodaBut.Click += new System.EventHandler(this.SodaBut_Click);
            // 
            // SoftDrinkBut
            // 
            this.SoftDrinkBut.Name = "SoftDrinkBut";
            this.SoftDrinkBut.Size = new System.Drawing.Size(189, 30);
            this.SoftDrinkBut.Text = "Soft Drink";
            this.SoftDrinkBut.Click += new System.EventHandler(this.SoftDrinkBut_Click);
            // 
            // TeaBut
            // 
            this.TeaBut.Name = "TeaBut";
            this.TeaBut.Size = new System.Drawing.Size(189, 30);
            this.TeaBut.Text = "Tea";
            this.TeaBut.Click += new System.EventHandler(this.TeaBut_Click);
            // 
            // EditItemBut
            // 
            this.EditItemBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditItemBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItemBut.Image = ((System.Drawing.Image)(resources.GetObject("EditItemBut.Image")));
            this.EditItemBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditItemBut.Name = "EditItemBut";
            this.EditItemBut.Size = new System.Drawing.Size(121, 29);
            this.EditItemBut.Text = "Edit Products";
            this.EditItemBut.Click += new System.EventHandler(this.EditItemBut_Click);
            // 
            // AboutBut
            // 
            this.AboutBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBut.Image = ((System.Drawing.Image)(resources.GetObject("AboutBut.Image")));
            this.AboutBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutBut.Name = "AboutBut";
            this.AboutBut.Size = new System.Drawing.Size(91, 29);
            this.AboutBut.Text = "About Us";
            this.AboutBut.Click += new System.EventHandler(this.AboutBut_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoginButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoginButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginBut,
            this.EditProflieBut,
            this.SignUpBut,
            this.SignOutBut});
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginButton.Size = new System.Drawing.Size(70, 29);
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginBut
            // 
            this.LoginBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoginBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginBut.Size = new System.Drawing.Size(168, 30);
            this.LoginBut.Text = "Login";
            this.LoginBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // EditProflieBut
            // 
            this.EditProflieBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProflieBut.Name = "EditProflieBut";
            this.EditProflieBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditProflieBut.Size = new System.Drawing.Size(168, 30);
            this.EditProflieBut.Text = "Edit";
            this.EditProflieBut.Click += new System.EventHandler(this.EditProfileBut_Click);
            // 
            // SignUpBut
            // 
            this.SignUpBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBut.Name = "SignUpBut";
            this.SignUpBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignUpBut.Size = new System.Drawing.Size(168, 30);
            this.SignUpBut.Text = "Sign Up";
            this.SignUpBut.Click += new System.EventHandler(this.SignUpBut_Click);
            // 
            // SignOutBut
            // 
            this.SignOutBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBut.Name = "SignOutBut";
            this.SignOutBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignOutBut.Size = new System.Drawing.Size(168, 30);
            this.SignOutBut.Text = "Sign Out";
            this.SignOutBut.Click += new System.EventHandler(this.SignOutBut_Click);
            // 
            // FindBox
            // 
            this.FindBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FindBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(200, 32);
            this.FindBox.TextChanged += new System.EventHandler(this.FindBox_TextChange);
            // 
            // TableBut
            // 
            this.TableBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TableBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableBut.Image = ((System.Drawing.Image)(resources.GetObject("TableBut.Image")));
            this.TableBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TableBut.Name = "TableBut";
            this.TableBut.Size = new System.Drawing.Size(56, 29);
            this.TableBut.Text = "Table";
            this.TableBut.Click += new System.EventHandler(this.TableBut_Click);
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameLabel.Location = new System.Drawing.Point(546, 44);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(164, 22);
            this.ShopNameLabel.TabIndex = 2;
            this.ShopNameLabel.Text = "TRAIL EXPRESS";
            this.ShopNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 647);
            this.Controls.Add(this.ShopNameLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ItemGrid);
            this.Name = "FMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton HomeBut;
        private System.Windows.Forms.ToolStripDropDownButton ItemBut;
        private System.Windows.Forms.ToolStripMenuItem CoffeeBut;
        private System.Windows.Forms.ToolStripMenuItem CakeBut;
        private System.Windows.Forms.ToolStripMenuItem IceBlendedBut;
        private System.Windows.Forms.ToolStripMenuItem SodaBut;
        private System.Windows.Forms.ToolStripMenuItem SoftDrinkBut;
        private System.Windows.Forms.ToolStripMenuItem TeaBut;
        private System.Windows.Forms.ToolStripButton EditItemBut;
        private System.Windows.Forms.ToolStripButton AboutBut;
        private System.Windows.Forms.ToolStripDropDownButton LoginButton;
        private System.Windows.Forms.ToolStripMenuItem LoginBut;
        private System.Windows.Forms.ToolStripMenuItem EditProflieBut;
        private System.Windows.Forms.ToolStripMenuItem SignUpBut;
        private System.Windows.Forms.ToolStripMenuItem SignOutBut;
        private System.Windows.Forms.Label ShopNameLabel;
        private System.Windows.Forms.ToolStripTextBox FindBox;
        private System.Windows.Forms.ToolStripButton TableBut;
    }
}