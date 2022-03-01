using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation_en_ligne
{
    public partial class menuprincipalmedecin : Form
    {
        public menuprincipalmedecin()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestion_patients patients = new gestion_patients();
            patients.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionrendezvous rdv = new gestionrendezvous();
            rdv.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionmaladie rdv = new gestionmaladie();
            rdv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionsymptome rdv = new gestionsymptome();
            rdv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestiontraitement rdv = new gestiontraitement();
            rdv.Show();
        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainframe rdv = new mainframe();
            rdv.Show();
        }
    }
}
