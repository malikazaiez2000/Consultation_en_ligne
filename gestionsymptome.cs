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
    public partial class gestionsymptome : Form
    {
        public gestionsymptome()
        {
            InitializeComponent();
            
            populate();
        }

        private void gestionsymptome_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populate()
        {

            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `symptome` FROM `symptomes` ", ss))
            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,symptome FROM symptomes where id= '" + idcheckbox.Text + "'", ss))

            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void ajoutbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `symptomes`(`id`, `symptome`) VALUES (@id,@fn)", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
          

            MessageBox.Show("Symptome creer avec succée", "Symptome Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void supprimebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("delete from symptomes where id='" + idcheckbox.Text + "'", db.getConnection());




            MessageBox.Show("symptome supprimé avec succée", "symptome Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void modifierbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("Update symptomes set  symptome=@fn where id=@id", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
        

            MessageBox.Show("Symptome modifier avec succée", "Symptome Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
