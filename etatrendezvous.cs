using MySql.Data.MySqlClient;
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
    public partial class etatrendezvous : Form
    {
        public etatrendezvous()
        {
            InitializeComponent();
        }

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,prenom,nom,date,temp,status,prix FROM reservation where code= '" + codecheckbox.Text + "'", ss))

            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuprincipal menu = new menuprincipal();
            menu.Show();
        }
    }
}
