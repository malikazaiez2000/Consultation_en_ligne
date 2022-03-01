
namespace Consultation_en_ligne
{
    partial class gestionrendezvous
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
            this.prixcheckbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Recherchebutton = new System.Windows.Forms.Button();
            this.affichebutton = new System.Windows.Forms.Button();
            this.supprimebutton = new System.Windows.Forms.Button();
            this.modifierbutton = new System.Windows.Forms.Button();
            this.ajoutbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statuscheckbox = new System.Windows.Forms.TextBox();
            this.prenomcheckbox = new System.Windows.Forms.TextBox();
            this.nomcheckbox = new System.Windows.Forms.TextBox();
            this.idcheckbox = new System.Windows.Forms.TextBox();
            this.gestionpatienttable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelregister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionpatienttable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.labelregister);
            this.panel1.Controls.Add(this.prixcheckbox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Recherchebutton);
            this.panel1.Controls.Add(this.affichebutton);
            this.panel1.Controls.Add(this.supprimebutton);
            this.panel1.Controls.Add(this.modifierbutton);
            this.panel1.Controls.Add(this.ajoutbutton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statuscheckbox);
            this.panel1.Controls.Add(this.prenomcheckbox);
            this.panel1.Controls.Add(this.nomcheckbox);
            this.panel1.Controls.Add(this.idcheckbox);
            this.panel1.Controls.Add(this.gestionpatienttable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 591);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // prixcheckbox
            // 
            this.prixcheckbox.ForeColor = System.Drawing.Color.Gray;
            this.prixcheckbox.Location = new System.Drawing.Point(131, 486);
            this.prixcheckbox.Name = "prixcheckbox";
            this.prixcheckbox.Size = new System.Drawing.Size(148, 27);
            this.prixcheckbox.TabIndex = 221;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 220;
            this.label8.Text = "Prix";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " ";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 373);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 219;
            this.dateTimePicker2.Value = new System.DateTime(2021, 12, 1, 16, 34, 0, 0);
            this.dateTimePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker2_KeyDown);
            this.dateTimePicker2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker2_MouseDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 321);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 218;
            // 
            // Recherchebutton
            // 
            this.Recherchebutton.Location = new System.Drawing.Point(773, 540);
            this.Recherchebutton.Name = "Recherchebutton";
            this.Recherchebutton.Size = new System.Drawing.Size(94, 29);
            this.Recherchebutton.TabIndex = 217;
            this.Recherchebutton.Text = "Rechercher";
            this.Recherchebutton.UseVisualStyleBackColor = true;
            this.Recherchebutton.Click += new System.EventHandler(this.Recherchebutton_Click);
            // 
            // affichebutton
            // 
            this.affichebutton.Location = new System.Drawing.Point(451, 540);
            this.affichebutton.Name = "affichebutton";
            this.affichebutton.Size = new System.Drawing.Size(94, 29);
            this.affichebutton.TabIndex = 216;
            this.affichebutton.Text = "afficher";
            this.affichebutton.UseVisualStyleBackColor = true;
            this.affichebutton.Click += new System.EventHandler(this.affichebutton_Click);
            // 
            // supprimebutton
            // 
            this.supprimebutton.Location = new System.Drawing.Point(166, 540);
            this.supprimebutton.Name = "supprimebutton";
            this.supprimebutton.Size = new System.Drawing.Size(94, 29);
            this.supprimebutton.TabIndex = 215;
            this.supprimebutton.Text = "Supprimer";
            this.supprimebutton.UseVisualStyleBackColor = true;
            this.supprimebutton.Click += new System.EventHandler(this.supprimebutton_Click);
            // 
            // modifierbutton
            // 
            this.modifierbutton.Location = new System.Drawing.Point(310, 540);
            this.modifierbutton.Name = "modifierbutton";
            this.modifierbutton.Size = new System.Drawing.Size(94, 29);
            this.modifierbutton.TabIndex = 214;
            this.modifierbutton.Text = "Modifier";
            this.modifierbutton.UseVisualStyleBackColor = true;
            this.modifierbutton.Click += new System.EventHandler(this.modifierbutton_Click);
            // 
            // ajoutbutton
            // 
            this.ajoutbutton.Location = new System.Drawing.Point(31, 540);
            this.ajoutbutton.Name = "ajoutbutton";
            this.ajoutbutton.Size = new System.Drawing.Size(94, 29);
            this.ajoutbutton.TabIndex = 213;
            this.ajoutbutton.Text = "Ajouter";
            this.ajoutbutton.UseVisualStyleBackColor = true;
            this.ajoutbutton.Click += new System.EventHandler(this.ajoutbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 212;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 211;
            this.label6.Text = "Horaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 210;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 209;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 208;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 207;
            this.label2.Text = "lD";
            // 
            // statuscheckbox
            // 
            this.statuscheckbox.ForeColor = System.Drawing.Color.Gray;
            this.statuscheckbox.Location = new System.Drawing.Point(131, 428);
            this.statuscheckbox.Name = "statuscheckbox";
            this.statuscheckbox.Size = new System.Drawing.Size(148, 27);
            this.statuscheckbox.TabIndex = 206;
            // 
            // prenomcheckbox
            // 
            this.prenomcheckbox.ForeColor = System.Drawing.Color.Gray;
            this.prenomcheckbox.Location = new System.Drawing.Point(131, 261);
            this.prenomcheckbox.Name = "prenomcheckbox";
            this.prenomcheckbox.Size = new System.Drawing.Size(148, 27);
            this.prenomcheckbox.TabIndex = 203;
            // 
            // nomcheckbox
            // 
            this.nomcheckbox.ForeColor = System.Drawing.Color.Gray;
            this.nomcheckbox.Location = new System.Drawing.Point(131, 203);
            this.nomcheckbox.Name = "nomcheckbox";
            this.nomcheckbox.Size = new System.Drawing.Size(148, 27);
            this.nomcheckbox.TabIndex = 202;
            // 
            // idcheckbox
            // 
            this.idcheckbox.ForeColor = System.Drawing.Color.Gray;
            this.idcheckbox.Location = new System.Drawing.Point(131, 140);
            this.idcheckbox.Name = "idcheckbox";
            this.idcheckbox.Size = new System.Drawing.Size(148, 27);
            this.idcheckbox.TabIndex = 201;
            // 
            // gestionpatienttable
            // 
            this.gestionpatienttable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gestionpatienttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestionpatienttable.Location = new System.Drawing.Point(402, 193);
            this.gestionpatienttable.Name = "gestionpatienttable";
            this.gestionpatienttable.RowHeadersWidth = 51;
            this.gestionpatienttable.RowTemplate.Height = 29;
            this.gestionpatienttable.Size = new System.Drawing.Size(803, 188);
            this.gestionpatienttable.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 102);
            this.panel2.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClose.Location = new System.Drawing.Point(1196, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(29, 31);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(438, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion Des Rendez-Vous";
            // 
            // labelregister
            // 
            this.labelregister.AutoSize = true;
            this.labelregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelregister.ForeColor = System.Drawing.Color.Snow;
            this.labelregister.Location = new System.Drawing.Point(959, 540);
            this.labelregister.Name = "labelregister";
            this.labelregister.Size = new System.Drawing.Size(197, 20);
            this.labelregister.TabIndex = 222;
            this.labelregister.Text = "Retourner au menu principal";
            this.labelregister.Click += new System.EventHandler(this.labelregister_Click);
            // 
            // gestionrendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionrendezvous";
            this.Text = "gestionrendezvous";
            this.Load += new System.EventHandler(this.gestionrendezvous_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionpatienttable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Recherchebutton;
        private System.Windows.Forms.Button affichebutton;
        private System.Windows.Forms.Button supprimebutton;
        private System.Windows.Forms.Button modifierbutton;
        private System.Windows.Forms.Button ajoutbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statuscheckbox;
        private System.Windows.Forms.TextBox prenomcheckbox;
        private System.Windows.Forms.TextBox nomcheckbox;
        private System.Windows.Forms.TextBox idcheckbox;
        private System.Windows.Forms.DataGridView gestionpatienttable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox prixcheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelregister;
    }
}