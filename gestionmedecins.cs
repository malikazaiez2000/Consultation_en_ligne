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
    public partial class gestionmedecins : Form
    {
        public gestionmedecins()
        {
            InitializeComponent();
            populate();
        }
        void populate()
        {

            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`,`fname`,`lname`,`uname`,`pass` FROM `doctorinfo` ", ss))
            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }


        private void ajoutbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `doctorinfo`(`id`, `fname`, `lname`,`uname`, `pass` ) VALUES (@id,@fn,@ln,@se,@vl)", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@se", MySqlDbType.VarChar).Value = villecheckbox.Text;
           
            cmd.Parameters.Add("@vl", MySqlDbType.VarChar).Value = naissancecheckbox.Text;

            MessageBox.Show("Medecin creer avec succée", "Medecin Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void supprimebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("delete from doctorinfo where fname='" + prenomcheckbox.Text + "'", db.getConnection());




            MessageBox.Show("medecin supprimé avec succée", "medecin Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void modifierbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("Update userinfo set  fname=@fn, lname=@ln,uname=@se, pass=@vl where id=@id", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@se", MySqlDbType.VarChar).Value = naissancecheckbox.Text;
            
            cmd.Parameters.Add("@vl", MySqlDbType.VarChar).Value = villecheckbox;

            MessageBox.Show("medecin modifier avec succée", "Medecin Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void gestionmedecins_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,fname,lname,uname,pass FROM doctorinfo where id= '" + idcheckbox.Text + "'", ss))

            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuadmin menu = new menuadmin();
            menu.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
