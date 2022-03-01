
namespace Consultation_en_ligne
{
    partial class Register
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
            this.labelmenu = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxrepass = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.mailbutton = new System.Windows.Forms.TextBox();
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.nombutton = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.labelmenu);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBoxrepass);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.mailbutton);
            this.panel1.Controls.Add(this.firstnamebox);
            this.panel1.Controls.Add(this.registerbutton);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.nombutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 564);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelmenu
            // 
            this.labelmenu.AutoSize = true;
            this.labelmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelmenu.ForeColor = System.Drawing.Color.Snow;
            this.labelmenu.Location = new System.Drawing.Point(264, 535);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.Size = new System.Drawing.Size(197, 20);
            this.labelmenu.TabIndex = 203;
            this.labelmenu.Text = "Retourner au menu principal";
            this.labelmenu.Click += new System.EventHandler(this.labelregister_Click);
            this.labelmenu.MouseEnter += new System.EventHandler(this.labelregister_MouseEnter);
            this.labelmenu.MouseLeave += new System.EventHandler(this.labelregister_MouseLeave);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(378, 177);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 24);
            this.radioButton2.TabIndex = 202;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "FEMALE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(277, 177);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 201;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MALE";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxrepass
            // 
            this.textBoxrepass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxrepass.Location = new System.Drawing.Point(192, 426);
            this.textBoxrepass.Name = "textBoxrepass";
            this.textBoxrepass.Size = new System.Drawing.Size(350, 27);
            this.textBoxrepass.TabIndex = 12;
            this.textBoxrepass.Text = "confirmer password";
            this.textBoxrepass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxrepass.Enter += new System.EventHandler(this.textBoxrepass_Enter);
            this.textBoxrepass.Leave += new System.EventHandler(this.textBoxrepass_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(192, 367);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(350, 27);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "password";
            
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // mailbutton
            // 
            this.mailbutton.ForeColor = System.Drawing.Color.Gray;
            this.mailbutton.Location = new System.Drawing.Point(192, 243);
            this.mailbutton.Name = "mailbutton";
            this.mailbutton.Size = new System.Drawing.Size(350, 27);
            this.mailbutton.TabIndex = 10;
            this.mailbutton.Text = "email";
            this.mailbutton.Enter += new System.EventHandler(this.mailbutton_Enter);
            this.mailbutton.Leave += new System.EventHandler(this.mailbutton_Leave);
            // 
            // firstnamebox
            // 
            this.firstnamebox.ForeColor = System.Drawing.Color.Gray;
            this.firstnamebox.Location = new System.Drawing.Point(192, 119);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(148, 27);
            this.firstnamebox.TabIndex = 200;
            this.firstnamebox.Text = "prenom";
            this.firstnamebox.Enter += new System.EventHandler(this.firstnamebox_Enter);
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.LightCyan;
            this.registerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerbutton.ForeColor = System.Drawing.Color.Black;
            this.registerbutton.Location = new System.Drawing.Point(203, 479);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(326, 49);
            this.registerbutton.TabIndex = 5;
            this.registerbutton.Text = "creer votre compte";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(192, 303);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(350, 27);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "username";
            this.textBoxUsername.Enter += new System.EventHandler(this.usernamebutton_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.usernamebutton_Leave);
            // 
            // nombutton
            // 
            this.nombutton.ForeColor = System.Drawing.Color.Gray;
            this.nombutton.Location = new System.Drawing.Point(378, 119);
            this.nombutton.Name = "nombutton";
            this.nombutton.Size = new System.Drawing.Size(164, 27);
            this.nombutton.TabIndex = 1;
            this.nombutton.Text = "nom";
            this.nombutton.Enter += new System.EventHandler(this.nombutton_Enter);
            this.nombutton.Leave += new System.EventHandler(this.nombutton_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 102);
            this.panel2.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClose.Location = new System.Drawing.Point(633, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(29, 31);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.Enter += new System.EventHandler(this.labelClose_Enter);
            this.labelClose.Leave += new System.EventHandler(this.labelClose_Leave);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 564);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox nombutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.TextBox mailbutton;
        private System.Windows.Forms.TextBox textBoxrepass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelmenu;
    }
}