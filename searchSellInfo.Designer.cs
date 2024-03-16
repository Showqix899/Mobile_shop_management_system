namespace shopmgmt
{
    partial class searchSellInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numberCoustomer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.serachBtn = new System.Windows.Forms.Button();
            this.sellInfoDisplay = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellInfoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numberCoustomer);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.serachBtn);
            this.panel1.Controls.Add(this.sellInfoDisplay);
            this.panel1.Location = new System.Drawing.Point(30, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 717);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Insert Customer Phone Number";
            // 
            // numberCoustomer
            // 
            this.numberCoustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberCoustomer.Location = new System.Drawing.Point(23, 66);
            this.numberCoustomer.Name = "numberCoustomer";
            this.numberCoustomer.Size = new System.Drawing.Size(416, 38);
            this.numberCoustomer.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1118, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.backBtn);
            // 
            // serachBtn
            // 
            this.serachBtn.BackColor = System.Drawing.Color.Orange;
            this.serachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.serachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serachBtn.ForeColor = System.Drawing.Color.Black;
            this.serachBtn.Location = new System.Drawing.Point(466, 66);
            this.serachBtn.Name = "serachBtn";
            this.serachBtn.Size = new System.Drawing.Size(109, 38);
            this.serachBtn.TabIndex = 2;
            this.serachBtn.Text = "Search";
            this.serachBtn.UseVisualStyleBackColor = false;
            this.serachBtn.Click += new System.EventHandler(this.serachBtn_Click);
            // 
            // sellInfoDisplay
            // 
            this.sellInfoDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sellInfoDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellInfoDisplay.Location = new System.Drawing.Point(23, 114);
            this.sellInfoDisplay.Name = "sellInfoDisplay";
            this.sellInfoDisplay.Size = new System.Drawing.Size(1183, 587);
            this.sellInfoDisplay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1269, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clsBtn);
            // 
            // showSellInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1313, 785);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "showSellInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showSellInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellInfoDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberCoustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button serachBtn;
        private System.Windows.Forms.DataGridView sellInfoDisplay;
        private System.Windows.Forms.Button button1;
    }
}