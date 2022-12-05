namespace TetszolegesWinForm
{
    partial class MainGUI
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
            this.VideojatekAdatai_Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDText_Main = new System.Windows.Forms.TextBox();
            this.JateknevText_Main = new System.Windows.Forms.TextBox();
            this.JatekfajText_Main = new System.Windows.Forms.TextBox();
            this.JatekevNumUpDown_Main = new System.Windows.Forms.NumericUpDown();
            this.JatekPlatText_Main = new System.Windows.Forms.TextBox();
            this.UjAdatButton_Main = new System.Windows.Forms.Button();
            this.AdatModButton_Main = new System.Windows.Forms.Button();
            this.AdatTorButton_Main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VideojatekAdatai_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JatekevNumUpDown_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // VideojatekAdatai_Grid
            // 
            this.VideojatekAdatai_Grid.AllowUserToAddRows = false;
            this.VideojatekAdatai_Grid.AllowUserToDeleteRows = false;
            this.VideojatekAdatai_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideojatekAdatai_Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VideojatekAdatai_Grid.Location = new System.Drawing.Point(0, 408);
            this.VideojatekAdatai_Grid.Name = "VideojatekAdatai_Grid";
            this.VideojatekAdatai_Grid.ReadOnly = true;
            this.VideojatekAdatai_Grid.Size = new System.Drawing.Size(1200, 250);
            this.VideojatekAdatai_Grid.TabIndex = 0;
            this.VideojatekAdatai_Grid.SelectionChanged += new System.EventHandler(this.VideojatekAdatai_Grid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Videójátékok adatai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Játékneve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Játék Faja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Játék éve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(857, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Játék platformja:";
            // 
            // IDText_Main
            // 
            this.IDText_Main.Location = new System.Drawing.Point(49, 124);
            this.IDText_Main.Name = "IDText_Main";
            this.IDText_Main.ReadOnly = true;
            this.IDText_Main.Size = new System.Drawing.Size(100, 26);
            this.IDText_Main.TabIndex = 7;
            // 
            // JateknevText_Main
            // 
            this.JateknevText_Main.Location = new System.Drawing.Point(275, 124);
            this.JateknevText_Main.Name = "JateknevText_Main";
            this.JateknevText_Main.Size = new System.Drawing.Size(100, 26);
            this.JateknevText_Main.TabIndex = 8;
            // 
            // JatekfajText_Main
            // 
            this.JatekfajText_Main.Location = new System.Drawing.Point(509, 124);
            this.JatekfajText_Main.Name = "JatekfajText_Main";
            this.JatekfajText_Main.Size = new System.Drawing.Size(100, 26);
            this.JatekfajText_Main.TabIndex = 9;
            // 
            // JatekevNumUpDown_Main
            // 
            this.JatekevNumUpDown_Main.Location = new System.Drawing.Point(742, 124);
            this.JatekevNumUpDown_Main.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.JatekevNumUpDown_Main.Minimum = new decimal(new int[] {
            1947,
            0,
            0,
            0});
            this.JatekevNumUpDown_Main.Name = "JatekevNumUpDown_Main";
            this.JatekevNumUpDown_Main.Size = new System.Drawing.Size(60, 26);
            this.JatekevNumUpDown_Main.TabIndex = 10;
            this.JatekevNumUpDown_Main.Value = new decimal(new int[] {
            1947,
            0,
            0,
            0});
            // 
            // JatekPlatText_Main
            // 
            this.JatekPlatText_Main.Location = new System.Drawing.Point(987, 124);
            this.JatekPlatText_Main.Name = "JatekPlatText_Main";
            this.JatekPlatText_Main.Size = new System.Drawing.Size(100, 26);
            this.JatekPlatText_Main.TabIndex = 11;
            // 
            // UjAdatButton_Main
            // 
            this.UjAdatButton_Main.Location = new System.Drawing.Point(77, 263);
            this.UjAdatButton_Main.Name = "UjAdatButton_Main";
            this.UjAdatButton_Main.Size = new System.Drawing.Size(192, 72);
            this.UjAdatButton_Main.TabIndex = 12;
            this.UjAdatButton_Main.Text = "Új Adat";
            this.UjAdatButton_Main.UseVisualStyleBackColor = true;
            this.UjAdatButton_Main.Click += new System.EventHandler(this.UjAdatButton_Main_Click);
            // 
            // AdatModButton_Main
            // 
            this.AdatModButton_Main.Location = new System.Drawing.Point(490, 263);
            this.AdatModButton_Main.Name = "AdatModButton_Main";
            this.AdatModButton_Main.Size = new System.Drawing.Size(192, 72);
            this.AdatModButton_Main.TabIndex = 13;
            this.AdatModButton_Main.Text = "Adat Módosítás";
            this.AdatModButton_Main.UseVisualStyleBackColor = true;
            this.AdatModButton_Main.Click += new System.EventHandler(this.AdatModButton_Main_Click);
            // 
            // AdatTorButton_Main
            // 
            this.AdatTorButton_Main.Location = new System.Drawing.Point(861, 263);
            this.AdatTorButton_Main.Name = "AdatTorButton_Main";
            this.AdatTorButton_Main.Size = new System.Drawing.Size(192, 72);
            this.AdatTorButton_Main.TabIndex = 14;
            this.AdatTorButton_Main.Text = "Adat Törlés";
            this.AdatTorButton_Main.UseVisualStyleBackColor = true;
            this.AdatTorButton_Main.Click += new System.EventHandler(this.AdatTorButton_Main_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.AdatTorButton_Main);
            this.Controls.Add(this.AdatModButton_Main);
            this.Controls.Add(this.UjAdatButton_Main);
            this.Controls.Add(this.JatekPlatText_Main);
            this.Controls.Add(this.JatekevNumUpDown_Main);
            this.Controls.Add(this.JatekfajText_Main);
            this.Controls.Add(this.JateknevText_Main);
            this.Controls.Add(this.IDText_Main);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VideojatekAdatai_Grid);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideojatekAdatai_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JatekevNumUpDown_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VideojatekAdatai_Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AdatModButton_Main;
        private System.Windows.Forms.Button AdatTorButton_Main;
        public System.Windows.Forms.TextBox IDText_Main;
        public System.Windows.Forms.TextBox JateknevText_Main;
        public System.Windows.Forms.TextBox JatekfajText_Main;
        public System.Windows.Forms.NumericUpDown JatekevNumUpDown_Main;
        public System.Windows.Forms.TextBox JatekPlatText_Main;
        public System.Windows.Forms.Button UjAdatButton_Main;
    }
}

