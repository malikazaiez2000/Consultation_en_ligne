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
    public partial class Register : Form
    {
        string g;
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnamebox_Enter(object sender, EventArgs e)
        {
            String fname = firstnamebox.Text;
            if(fname.ToLower().Trim().Equals("prenom"))
            {
                firstnamebox.Text = "";
                firstnamebox.ForeColor = Color.Black;
            }
        }

        private void firstnamebox_Leave(object sender, EventArgs e)
        {
            String fname = firstnamebox.Text;
            if (fname.ToLower().Trim().Equals("prenom") || fname.Trim().Equals(""))    //Trim méthode rim qui coupe une chaîne aux deux extrémités en supprimant les espaces blancs ou un caractère spécifié    
            {
                firstnamebox.Text = "prenom";
                firstnamebox.ForeColor = Color.Gray;
            }
        }



        private void Register_Load(object sender, EventArgs e)
        {
            // annuler le focus de textboxes
            this.ActiveControl = label1;
        }

        private void nombutton_Enter(object sender, EventArgs e)
        {
            String lname = nombutton.Text;
            if (lname.ToLower().Trim().Equals("nom"))
            {
                nombutton.Text = "";
                nombutton.ForeColor = Color.Black;
            }
        }
        private void nombutton_Leave(object sender, EventArgs e)
        {
            String lname = nombutton.Text;
            if (lname.ToLower().Trim().Equals("nom") || lname.Trim().Equals(""))    //Trim méthode rim qui coupe une chaîne aux deux extrémités en supprimant les espaces blancs ou un caractère spécifié    
            {
                nombutton.Text = "nom";
                nombutton.ForeColor = Color.Gray;
            }
        }

        private void mailbutton_Enter(object sender, EventArgs e)
        {
            String adressmail = mailbutton.Text;
            if (adressmail.ToLower().Trim().Equals("email"))
            {
                mailbutton.Text = "";
                mailbutton.ForeColor = Color.Black;
            }
        }

        private void mailbutton_Leave(object sender, EventArgs e)
        {
            String adressmail = mailbutton.Text;
            if (adressmail.ToLower().Trim().Equals("email") || adressmail.Trim().Equals(""))    //Trim méthode rim qui coupe une chaîne aux deux extrémités en supprimant les espaces blancs ou un caractère spécifié    
            {
                mailbutton.Text = "email";
                mailbutton.ForeColor = Color.Gray;
            }

        }

        private void usernamebutton_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }

        }

        private void usernamebutton_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))    //Trim méthode rim qui coupe une chaîne aux deux extrémités en supprimant les espaces blancs ou un caractère spécifié    
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxrepass_Enter(object sender, EventArgs e)
        {
            String repassword = textBoxrepass.Text;
            if (repassword.ToLower().Trim().Equals("confirmer password"))
            {
                textBoxrepass.Text = "";
                textBoxrepass.UseSystemPasswordChar = true;
                textBoxrepass.ForeColor = Color.Black;
            }

        }

        private void textBoxrepass_Leave(object sender, EventArgs e)
        {
            String repassword = textBoxrepass.Text;
            if (repassword.ToLower().Trim().Equals("confirmer password") ||
                repassword.ToLower().Trim().Equals("password") ||
                repassword.Trim().Equals(""))
            {
                textBoxrepass.Text = "confirmer password";
                textBoxrepass.UseSystemPasswordChar = false;
                textBoxrepass.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClose_Enter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_Leave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                g = "MALE";
            }
            else
                g = "Female";


            database db = new database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `userinfo`(`fname`, `lname`, `uname`,`adresse`, `pass`, `sexe` ) VALUES (@fn,@ln,@un,@ad,@pa,@se)", db.getConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstnamebox.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = nombutton.Text;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = mailbutton.Text;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@se", MySqlDbType.VarChar).Value = g;

            //ouvrir connection
            db.ouvrirConnection();


            //verifier si les textboxes contiennet les valeurs par défaut
            if(!checkTextBoxesValues())
            {
                
                
                //verifier si le mot de passe et le mot de passe à retaper sont identiques.
                if(textBoxPassword.Text.Equals(textBoxrepass.Text))
                {
                    // verifier si le nom d'utilisateur existe déja
                    if (checkUsername())
                    {
                        MessageBox.Show("cet utilisateur existe déja!","Utilisateur Existant",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
                    {





                        int x = command.ExecuteNonQuery();
                        Console.Write("res = " + x);
                        if (x == 1)
                        {
                            MessageBox.Show("Compte creer avec succée","Compte",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la creation de la compte");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Votre mot passe n'est pas identique!","Erreur Mot de passe", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }



               
            }
            else
            {
                MessageBox.Show("Entrer vos informations avant de procéder", "Informations Manquants", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            


            //fermer connection
            db.fermerConnection();

        }
        public Boolean checkUsername()
        {
            database db = new database();
            String username = textBoxUsername.Text;
            

            DataTable table = new DataTable(); //MySQLDataAdapter, sert de pont entre un DataSet et MySQL pour la récupération et la sauvegarde des données.

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userinfo` WHERE `uname`=@username ", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
           

            adapter.SelectCommand = command; //utilisée pour sélectionner des enregistrements dans la source de données.
            adapter.Fill(table);

            //verifier si l'utilisateur existe ou pas
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }




           
        }
        //verifier si les textbox contiennent les valeurs par défaut
        public Boolean checkTextBoxesValues()
        {
            String fname = firstnamebox.Text;
            String lname = nombutton.Text;
            String email = mailbutton.Text;
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if (fname.Equals("prenom") || lname.Equals("nom") || email.Equals("email") || uname.Equals("username") || pass.Equals("password"))
            {
                return true;

            }
            else
            {

                return false;
            }
        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform login = new Loginform();
            login.Show();
        }

        private void labelregister_MouseEnter(object sender, EventArgs e)
        {
            labelmenu.ForeColor = Color.Yellow;
        }

        private void labelregister_MouseLeave(object sender, EventArgs e)
        {
            labelmenu.ForeColor = Color.White;
        }

        
    }



}
