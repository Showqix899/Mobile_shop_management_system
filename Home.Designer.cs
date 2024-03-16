namespace shopmgmt
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.sellInformation = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(604, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "HOME";
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Orange;
            this.admin.Location = new System.Drawing.Point(194, 239);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(104, 37);
            this.admin.TabIndex = 14;
            this.admin.Text = "ADMIN";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.Orange;
            this.stock.Location = new System.Drawing.Point(194, 488);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(104, 37);
            this.stock.TabIndex = 16;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // sellInformation
            // 
            this.sellInformation.BackColor = System.Drawing.Color.Orange;
            this.sellInformation.Location = new System.Drawing.Point(190, 239);
            this.sellInformation.Name = "sellInformation";
            this.sellInformation.Size = new System.Drawing.Size(104, 37);
            this.sellInformation.TabIndex = 17;
            this.sellInformation.Text = "Sell Information";
            this.sellInformation.UseVisualStyleBackColor = false;
            this.sellInformation.Click += new System.EventHandler(this.sellInfo);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Orange;
            this.logOut.Location = new System.Drawing.Point(190, 491);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(104, 37);
            this.logOut.TabIndex = 18;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOutbtn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1350, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.closebtn);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 817);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shopmgmt.Properties.Resources.admin_icon_10;
            this.pictureBox1.Location = new System.Drawing.Point(163, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::shopmgmt.Properties.Resources.inventory;
            this.pictureBox5.Location = new System.Drawing.Point(163, 300);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(167, 171);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.sellInformation);
            this.panel2.Controls.Add(this.logOut);
            this.panel2.Location = new System.Drawing.Point(812, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 817);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::shopmgmt.Properties.Resources.logout;
            this.pictureBox4.Location = new System.Drawing.Point(155, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(167, 171);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::shopmgmt.Properties.Resources.sell;
            this.pictureBox3.Location = new System.Drawing.Point(155, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1392, 875);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Button sellInformation;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}