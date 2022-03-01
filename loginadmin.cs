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
    public partial class loginadmin : Form
    {
        public loginadmin()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {

            database db = new database();
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable(); //MySQLDataAdapter, sert de pont entre un DataSet et MySQL pour la récupération et la sauvegarde des données.

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admininfo` WHERE `uname`=@username and `pass`=@pass", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command; //utilisée pour sélectionner des enregistrements dans la source de données.
            adapter.Fill(table);

            //verifier si l'utilisateur existe ou pas
            if (table.Rows.Count > 0)
            {

                this.Hide();
                menuadmin patients = new menuadmin();
                patients.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Entrer votre username pour connecter", "Username manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Entrer votre mot de paase pour connecter", "mot de passe manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Votre username ou mot de passe est incorrecte", "Data Incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

