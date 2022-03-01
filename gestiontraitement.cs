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
    public partial class gestiontraitement : Form
    {
        public gestiontraitement()
        {
            InitializeComponent();
            populate();
        }
        void populate()
        {

            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `traitement_maladie` FROM `traitement` ", ss))
            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void ajoutbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `traitement`(`id`, `traitement_maladie`) VALUES (@id,@fn)", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;


            MessageBox.Show("Traitement creer avec succée", "Traitement Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void gestiontraitement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,traitement_maladie FROM traitement where id= '" + idcheckbox.Text + "'", ss))

            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void supprimebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("delete from traitement where id='" + idcheckbox.Text + "'", db.getConnection());




            MessageBox.Show("traitement supprimé avec succée", "traitement Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void modifierbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("Update traitement set  traitement_maladie=@fn where id=@id", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;


            MessageBox.Show("Traitement modifier avec succée", "Traitement Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void affichebutton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void labelregister_Click(object sender, EventArgs e)
        {

            this.Hide();
            menuprincipalmedecin menu = new menuprincipalmedecin();
            menu.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
