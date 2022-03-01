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
    public partial class gestion_patients : Form
    {
     
        public gestion_patients()
        {
            InitializeComponent();
            populate();
        }


        void populate()
        {
      
            database db = new database();
          
            MySqlConnection ss = db.getConnection();
            using (ss) 
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`,`fname`,`lname`,`bdate`,`sexe`,`ville`,`nom_maladie` FROM `userinfo` ", ss))
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

     

        private void ajoutbutton_Click(object sender, EventArgs e)
        {
            database db = new database();
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `userinfo`(`id`, `fname`, `lname`,`sexe`, `nom_maladie`, `ville` ) VALUES (@id,@fn,@ln,@se,@ml,@vl)", db.getConnection());

            
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@se", MySqlDbType.VarChar).Value = naissancecheckbox.Text;
            cmd.Parameters.Add("@ml", MySqlDbType.VarChar).Value = maladiecheckbox.Text;
            cmd.Parameters.Add("@vl", MySqlDbType.VarChar).Value = villecheckbox.Text;

            MessageBox.Show("Patient creer avec succée", "Patient Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
            

        }

     

        private void gestion_patients_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void supprimebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("delete from userinfo where fname='"+prenomcheckbox.Text+"'", db.getConnection());


           

            MessageBox.Show("Patient supprimé avec succée", "Patient Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("Update userinfo set  fname=@fn, lname=@ln,sexe=@se, nom_maladie=@ml, ville=@vl where id=@id", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@se", MySqlDbType.VarChar).Value = naissancecheckbox.Text;
            cmd.Parameters.Add("@ml", MySqlDbType.VarChar).Value = maladiecheckbox.Text;
            cmd.Parameters.Add("@vl", MySqlDbType.VarChar).Value = villecheckbox;

            MessageBox.Show("Patient modifier avec succée", "Patient Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,fname,lname,bdate,sexe,ville,nom_maladie FROM userinfo where id= '" + idcheckbox.Text + "'" , ss))
                
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuprincipalmedecin menu = new menuprincipalmedecin();
            menu.Show();
        }

        private void gestionpatienttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prenomcheckbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
