namespace CoffeeShopManageMent.UI_Layer
{
    partial class FEditItem
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
            this.EditItemGridView = new System.Windows.Forms.DataGridView();
            this.AddBut = new System.Windows.Forms.Button();
            this.UpdBut = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.EdIdBox = new System.Windows.Forms.TextBox();
            this.EdQanBox = new System.Windows.Forms.TextBox();
            this.EdPriBox = new System.Windows.Forms.TextBox();
            this.EdNamBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EdTypBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditItemGridView
            // 
            this.EditItemGridView.AllowUserToAddRows = false;
            this.EditItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EditItemGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EditItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditItemGridView.Location = new System.Drawing.Point(2, 262);
            this.EditItemGridView.Name = "EditItemGridView";
            this.EditItemGridView.RowHeadersWidth = 51;
            this.EditItemGridView.RowTemplate.Height = 24;
            this.EditItemGridView.Size = new System.Drawing.Size(587, 299);
            this.EditItemGridView.TabIndex = 0;
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(249)))));
            this.AddBut.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic);
            this.AddBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.AddBut.Location = new System.Drawing.Point(501, 22);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 50);
            this.AddBut.TabIndex = 1;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // UpdBut
            // 
            this.UpdBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(249)))));
            this.UpdBut.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic);
            this.UpdBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.UpdBut.Location = new System.Drawing.Point(501, 101);
            this.UpdBut.Name = "UpdBut";
            this.UpdBut.Size = new System.Drawing.Size(75, 50);
            this.UpdBut.TabIndex = 2;
            this.UpdBut.Text = "Update";
            this.UpdBut.UseVisualStyleBackColor = false;
            this.UpdBut.Click += new System.EventHandler(this.UpdBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(249)))));
            this.DelBut.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic);
            this.DelBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.DelBut.Location = new System.Drawing.Point(501, 181);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(75, 50);
            this.DelBut.TabIndex = 3;
            this.DelBut.Text = "Delete";
            this.DelBut.UseVisualStyleBackColor = false;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // EdIdBox
            // 
            this.EdIdBox.Location = new System.Drawing.Point(115, 22);
            this.EdIdBox.Name = "EdIdBox";
            this.EdIdBox.Size = new System.Drawing.Size(218, 22);
            this.EdIdBox.TabIndex = 4;
            // 
            // EdQanBox
            // 
            this.EdQanBox.Location = new System.Drawing.Point(115, 211);
            this.EdQanBox.Name = "EdQanBox";
            this.EdQanBox.Size = new System.Drawing.Size(218, 22);
            this.EdQanBox.TabIndex = 5;
            // 
            // EdPriBox
            // 
            this.EdPriBox.Location = new System.Drawing.Point(115, 115);
            this.EdPriBox.Name = "EdPriBox";
            this.EdPriBox.Size = new System.Drawing.Size(218, 22);
            this.EdPriBox.TabIndex = 6;
            // 
            // EdNamBox
            // 
            this.EdNamBox.Location = new System.Drawing.Point(115, 68);
            this.EdNamBox.Name = "EdNamBox";
            this.EdNamBox.Size = new System.Drawing.Size(218, 22);
            this.EdNamBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(-1, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(-1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(-1, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(-2, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(19)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(-2, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Item Type";
            // 
            // EdTypBox
            // 
            this.EdTypBox.FormattingEnabled = true;
            this.EdTypBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07"});
            this.EdTypBox.Location = new System.Drawing.Point(115, 162);
            this.EdTypBox.Name = "EdTypBox";
            this.EdTypBox.Size = new System.Drawing.Size(218, 24);
            this.EdTypBox.TabIndex = 13;
            // 
            // FEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(243)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(588, 563);
            this.Controls.Add(this.EdTypBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdNamBox);
            this.Controls.Add(this.EdPriBox);
            this.Controls.Add(this.EdQanBox);
            this.Controls.Add(this.EdIdBox);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.UpdBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.EditItemGridView);
            this.Name = "FEditItem";
            this.Text = "FEditItem";
            ((System.ComponentModel.ISupportInitialize)(this.EditItemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditItemGridView;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button UpdBut;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.TextBox EdIdBox;
        private System.Windows.Forms.TextBox EdQanBox;
        private System.Windows.Forms.TextBox EdPriBox;
        private System.Windows.Forms.TextBox EdNamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EdTypBox;
    }
}