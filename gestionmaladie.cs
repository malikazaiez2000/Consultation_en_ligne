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
    public partial class gestionmaladie : Form
    {
        public gestionmaladie()
        {
            InitializeComponent();
            populate();
        }
        void populate()
        {

            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `nom_maladie`,`gravite_maladie`,`description_maladie` FROM `maladie` ", ss))
            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        



        private void gestion_patients_Load(object sender, EventArgs e)
        {
            populate();
        }

       

     

      

        

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void gestionpatienttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gestionpatienttable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Recherchebutton_Click_1(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,nom_maladie,gravite_maladie,description_maladie FROM maladie where id= '" + idcheckbox.Text + "'", ss))

            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void ajoutbutton_Click_1(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `maladie`(`id`, `nom_maladie`, `gravite_maladie`,`description_maladie`) VALUES (@id,@fn,@ln,@vl)", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@vl", MySqlDbType.VarChar).Value = villecheckbox;

            MessageBox.Show("maladie creer avec succée", "maladie Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();


        }

        private void supprimebutton_Click_1(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("delete from maladie where gravite_maladie='" + prenomcheckbox.Text + "'", db.getConnection());




            MessageBox.Show("maladie supprimé avec succée", "maladie Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void modifierbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("Update maladie set  nom_maladie=@fn, gravite_maladie=@ln,description_maladie=@se where id=@id", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@se", MySqlDbType.VarChar).Value = villecheckbox.Text;

            MessageBox.Show("Maladie modifier avec succée", "Maladie Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void labelregister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menuprincipalmedecin menu = new menuprincipalmedecin();
            menu.Show();
        }

        private void labelClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}

