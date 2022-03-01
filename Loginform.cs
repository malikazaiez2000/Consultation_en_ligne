using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Consultation_en_ligne
{
    public partial class Loginform : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=consultation");
        public Loginform()
        {
            InitializeComponent();
            this.textBoxUsername.AutoSize = false;
            this.textBoxUsername.Size = new Size(this.textBoxUsername.Size.Width, 50);
            this.textBoxPassword.AutoSize = false; //anuler auto size
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50); // set taille specifique
        }

       

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black; //Changer le couleur de X lorsque je mets le curseur sur "X" en noir
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White; // blanc
        }

        private void labelClose_login(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            database db = new database();
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable(); //MySQLDataAdapter, sert de pont entre un DataSet et MySQL pour la récupération et la sauvegarde des données.

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userinfo` WHERE `uname`=@username and `pass`=@pass", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command; //utilisée pour sélectionner des enregistrements dans la source de données.
            adapter.Fill(table);

            //verifier si l'utilisateur existe ou pas
            if (table.Rows.Count > 0)
            {
                
                this.Hide();
                menuprincipal patients = new menuprincipal();
                patients.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Entrer votre username pour connecter","Username manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Entrer votre mot de paase pour connecter", "mot de passe manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Votre username ou mot de passe est incorrecte", "Data Incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }




        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Register registerform = new Register();
            registerform.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            labelregister.ForeColor = Color.Yellow;
        }

        private void labelregister_MouseLeave(object sender, EventArgs e)
        {
            labelregister.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
