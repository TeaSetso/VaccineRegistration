namespace VaccineRegistration
{
    partial class Form1
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
            this.ID1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gendercb = new System.Windows.Forms.ComboBox();
            this.provincecb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ID1
            // 
            this.ID1.Location = new System.Drawing.Point(288, 102);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(175, 26);
            this.ID1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(288, 158);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(136, 26);
            this.Surnametxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firstname";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(288, 211);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(130, 26);
            this.nametxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Province";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vaccine Registration Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gendercb
            // 
            this.gendercb.FormattingEnabled = true;
            this.gendercb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercb.Location = new System.Drawing.Point(288, 260);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(121, 28);
            this.gendercb.TabIndex = 12;
            // 
            // provincecb
            // 
            this.provincecb.FormattingEnabled = true;
            this.provincecb.Items.AddRange(new object[] {
            "Gauteng",
            "Limpopo",
            "Mpumalanga",
            "KZN",
            "Northern Cape",
            "North West",
            "Eastern Cape",
            "Western Cape"});
            this.provincecb.Location = new System.Drawing.Point(288, 322);
            this.provincecb.Name = "provincecb";
            this.provincecb.Size = new System.Drawing.Size(121, 28);
            this.provincecb.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.provincecb);
            this.Controls.Add(this.gendercb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Surnametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID1);
            this.Name = "Form1";
            this.Text = "VaccineReg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox gendercb;
        private System.Windows.Forms.ComboBox provincecb;
    }
}

