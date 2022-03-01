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
    public partial class mainframe : Form
    {
        public mainframe()
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
            loginmedecin mdc = new loginmedecin();
            mdc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform patients = new Loginform();
            patients.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginadmin patients = new loginadmin();
            patients.Show();
        }
    }
}
