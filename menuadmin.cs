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
    public partial class menuadmin : Form
    {
        public menuadmin()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionmedecins stmp = new gestionmedecins();
            stmp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainframe rdv = new mainframe();
            rdv.Show();
        }
    }
}
