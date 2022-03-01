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
    public partial class InfoMaladie : Form
    {
        public InfoMaladie()
        {
            InitializeComponent();
        }

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,nom_maladie,gravite_maladie,description_maladie FROM maladie WHERE reference= '" + codecheckbox.Text + "'", ss))
            using (MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT id,traitement_maladie FROM traitement where reference= '" + codecheckbox.Text + "'", ss))

            {
                DataTable s = new DataTable();
                DataTable s1 = new DataTable();
                adapter.Fill(s);
                adapter1.Fill(s1);

                gestionpatienttable.DataSource = s;
                dataGridView1.DataSource = s1;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelregister_Click(object sender, EventArgs e) // menu principal
        {
            this.Hide();
            menuprincipal menu = new menuprincipal();
            menu.Show();
        }

        private void label5_Click(object sender, EventArgs e) // rendez-vous
        {
            this.Hide();
            rendezvous menurdv = new rendezvous();
            menurdv.Show();
        }
    }
    }

