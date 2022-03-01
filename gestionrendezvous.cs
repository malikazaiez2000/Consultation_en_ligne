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
    public partial class gestionrendezvous : Form
    {
        public gestionrendezvous()
        {
            InitializeComponent();
            populate();
        }

        void populate()
        {

            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`,`prenom`,`nom`,`date`,`temp`,`status`,`prix` FROM `reservation` ", ss))
            {
                DataTable s = new DataTable();
                adapter.Fill(s);

                gestionpatienttable.DataSource = s;
            }
        }











        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker2.CustomFormat = "HH:mm:ss";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {

                dateTimePicker2.CustomFormat = " ";
            }
        }

        private void ajoutbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `reservation`(`id`, `prenom`, `nom`,`date`, `temp`, `status`,`prix` ) VALUES (@id,@pr,@nm,@dt,@tmp,@st,@prs)", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@nm", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@dt", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@tmp", MySqlDbType.VarChar).Value = dateTimePicker2.Text;
            cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = statuscheckbox.Text;
            cmd.Parameters.Add("@prs", MySqlDbType.VarChar).Value = prixcheckbox.Text;

            MessageBox.Show("Rendez-vous creer avec succée", "Rendez-vous Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void gestionrendezvous_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void supprimebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("delete from reservation where prenom='" + prenomcheckbox.Text + "'", db.getConnection());




            MessageBox.Show("Rendez-vous supprimé avec succée", "Rendez-vous Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ouvrir connection
            db.ouvrirConnection();

            int x = cmd.ExecuteNonQuery();
            db.fermerConnection();
            populate();
        }

        private void modifierbutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlCommand cmd = new MySqlCommand("Update reservation set  prenom=@pr, nom=@nm,date=@dt, temp=@tm, status=@st, prix=@prix where id=@id", db.getConnection());


            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idcheckbox.Text;
            cmd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = nomcheckbox.Text;
            cmd.Parameters.Add("@nm", MySqlDbType.VarChar).Value = prenomcheckbox.Text;
            cmd.Parameters.Add("@dt", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@tmp", MySqlDbType.VarChar).Value = dateTimePicker2.Text;
            cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = statuscheckbox;
            cmd.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prixcheckbox;

            MessageBox.Show("Rendez-vous modifier avec succée", "Rendez-vous Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Recherchebutton_Click(object sender, EventArgs e)
        {
            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id,prenom,nom,date,temp,status,prix FROM reservation where id= '" + idcheckbox.Text + "'", ss))

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
            menuprincipalmedecin menu = new menuprincipalmedecin();
            menu.Show();
        }
    }
}
