namespace TetszolegesWinForm
{
    partial class UjAdatGUI
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
            this.JatekPlatText_Uj = new System.Windows.Forms.TextBox();
            this.JatekevNumUpDown_Uj = new System.Windows.Forms.NumericUpDown();
            this.JatekfajText_Uj = new System.Windows.Forms.TextBox();
            this.JateknevText_Uj = new System.Windows.Forms.TextBox();
            this.IDText_Uj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UjAdatButton_Uj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JatekevNumUpDown_Uj)).BeginInit();
            this.SuspendLayout();
            // 
            // JatekPlatText_Uj
            // 
            this.JatekPlatText_Uj.Location = new System.Drawing.Point(988, 162);
            this.JatekPlatText_Uj.Name = "JatekPlatText_Uj";
            this.JatekPlatText_Uj.Size = new System.Drawing.Size(100, 26);
            this.JatekPlatText_Uj.TabIndex = 22;
            // 
            // JatekevNumUpDown_Uj
            // 
            this.JatekevNumUpDown_Uj.Location = new System.Drawing.Point(743, 162);
            this.JatekevNumUpDown_Uj.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.JatekevNumUpDown_Uj.Minimum = new decimal(new int[] {
            1947,
            0,
            0,
            0});
            this.JatekevNumUpDown_Uj.Name = "JatekevNumUpDown_Uj";
            this.JatekevNumUpDown_Uj.Size = new System.Drawing.Size(60, 26);
            this.JatekevNumUpDown_Uj.TabIndex = 21;
            this.JatekevNumUpDown_Uj.Value = new decimal(new int[] {
            1947,
            0,
            0,
            0});
            // 
            // JatekfajText_Uj
            // 
            this.JatekfajText_Uj.Location = new System.Drawing.Point(510, 162);
            this.JatekfajText_Uj.Name = "JatekfajText_Uj";
            this.JatekfajText_Uj.Size = new System.Drawing.Size(100, 26);
            this.JatekfajText_Uj.TabIndex = 20;
            // 
            // JateknevText_Uj
            // 
            this.JateknevText_Uj.Location = new System.Drawing.Point(276, 162);
            this.JateknevText_Uj.Name = "JateknevText_Uj";
            this.JateknevText_Uj.Size = new System.Drawing.Size(100, 26);
            this.JateknevText_Uj.TabIndex = 19;
            // 
            // IDText_Uj
            // 
            this.IDText_Uj.Location = new System.Drawing.Point(50, 162);
            this.IDText_Uj.Name = "IDText_Uj";
            this.IDText_Uj.ReadOnly = true;
            this.IDText_Uj.Size = new System.Drawing.Size(100, 26);
            this.IDText_Uj.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(858, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Játék platformja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Játék éve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Játék Faja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Játékneve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(345, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Új videójátékok adatai";
            // 
            // UjAdatButton_Uj
            // 
            this.UjAdatButton_Uj.Location = new System.Drawing.Point(442, 340);
            this.UjAdatButton_Uj.Name = "UjAdatButton_Uj";
            this.UjAdatButton_Uj.Size = new System.Drawing.Size(192, 72);
            this.UjAdatButton_Uj.TabIndex = 23;
            this.UjAdatButton_Uj.Text = "Új adat hozzáadása";
            this.UjAdatButton_Uj.UseVisualStyleBackColor = true;
            this.UjAdatButton_Uj.Click += new System.EventHandler(this.UjAdatButton_Uj_Click);
            // 
            // UjAdatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.UjAdatButton_Uj);
            this.Controls.Add(this.JatekPlatText_Uj);
            this.Controls.Add(this.JatekevNumUpDown_Uj);
            this.Controls.Add(this.JatekfajText_Uj);
            this.Controls.Add(this.JateknevText_Uj);
            this.Controls.Add(this.IDText_Uj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UjAdatGUI";
            this.Text = "UjAdatGUI";
            this.Load += new System.EventHandler(this.UjAdatGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JatekevNumUpDown_Uj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox JatekPlatText_Uj;
        public System.Windows.Forms.NumericUpDown JatekevNumUpDown_Uj;
        public System.Windows.Forms.TextBox JatekfajText_Uj;
        public System.Windows.Forms.TextBox JateknevText_Uj;
        public System.Windows.Forms.TextBox IDText_Uj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button UjAdatButton_Uj;
    }
}