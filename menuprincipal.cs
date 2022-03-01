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
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            rendezvous rendezvousform = new rendezvous();
            rendezvousform.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            etatrendezvous etat = new etatrendezvous();
            etat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            symptomes stmp = new symptomes();
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
