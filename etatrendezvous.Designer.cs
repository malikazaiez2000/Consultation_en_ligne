
namespace Consultation_en_ligne
{
    partial class etatrendezvous
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
            this.labelregister = new System.Windows.Forms.Label();
            this.Recherchebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codecheckbox = new System.Windows.Forms.TextBox();
            this.gestionpatienttable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionpatienttable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.labelregister);
            this.panel1.Controls.Add(this.Recherchebutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.codecheckbox);
            this.panel1.Controls.Add(this.gestionpatienttable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 413);
            this.panel1.TabIndex = 3;
            // 
            // labelregister
            // 
            this.labelregister.AutoSize = true;
            this.labelregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelregister.ForeColor = System.Drawing.Color.Snow;
            this.labelregister.Location = new System.Drawing.Point(100, 270);
            this.labelregister.Name = "labelregister";
            this.labelregister.Size = new System.Drawing.Size(197, 20);
            this.labelregister.TabIndex = 218;
            this.labelregister.Text = "Retourner au menu principal";
            this.labelregister.Click += new System.EventHandler(this.labelregister_Click);
            // 
            // Recherchebutton
            // 
            this.Recherchebutton.Location = new System.Drawing.Point(153, 210);
            this.Recherchebutton.Name = "Recherchebutton";
            this.Recherchebutton.Size = new System.Drawing.Size(94, 29);
            this.Recherchebutton.TabIndex = 217;
            this.Recherchebutton.Text = "Rechercher";
            this.Recherchebutton.UseVisualStyleBackColor = true;
            this.Recherchebutton.Click += new System.EventHandler(this.Recherchebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 207;
            this.label2.Text = "Code";
            // 
            // codecheckbox
            // 
            this.codecheckbox.ForeColor = System.Drawing.Color.Gray;
            this.codecheckbox.Location = new System.Drawing.Point(131, 140);
            this.codecheckbox.Name = "codecheckbox";
            this.codecheckbox.Size = new System.Drawing.Size(148, 27);
            this.codecheckbox.TabIndex = 201;
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
            this.label1.Location = new System.Drawing.Point(509, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etat Rendez-vous";
            // 
            // etatrendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 413);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "etatrendezvous";
            this.Text = "etatrendezvous";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codecheckbox;
        private System.Windows.Forms.DataGridView gestionpatienttable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelregister;
    }
}