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
    public partial class rendezvous : Form
    {
        public rendezvous()
        {
            InitializeComponent();
            
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

        private void rendezvous_Load(object sender, EventArgs e)
        {
            // annuler le focus de textboxes
            this.ActiveControl = panel1;
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            database db = new database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `reservation`(`prenom`, `nom`, `date`,`temp`,`status` ) VALUES (@pr,@nm,@date,@temp,@st)", db.getConnection());
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
            command.Parameters.Add("@temp", MySqlDbType.VarChar).Value = dateTimePicker2.Text;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = "pending";

            //ouvrir connection
            db.ouvrirConnection();


            
            


               
               
                    // verifier si la date existe déja 
                    if (checkdate())
                    {
                        MessageBox.Show("ce jour ci n'est pas libre, choisis un autre jour!", "Rendez-vous Existant", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {





                        int x = command.ExecuteNonQuery();
                        Console.Write("res = " + x);
                        if (x == 1)
                        {
                            MessageBox.Show("Rendez-vous reservé avec succée", "Rendez-vous", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            menuprincipal menu = new menuprincipal();
                            menu.Show();
                }
                        else
                        {
                            MessageBox.Show("Erreur lors de la reservation");
                        }
                    }
                




            
            




            //fermer connection
            db.fermerConnection();

        }
        public Boolean checkdate()
        {
            database db = new database();
            String date = dateTimePicker1.Text;
            String temp = dateTimePicker2.Text;


            DataTable table = new DataTable(); //MySQLDataAdapter, sert de pont entre un DataSet et MySQL pour la récupération et la sauvegarde des données.

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservation` WHERE `date`=@dt AND `temp`=@tmp  ", db.getConnection());

            command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@tmp", MySqlDbType.VarChar).Value = temp;


            adapter.SelectCommand = command; //utilisée pour sélectionner des enregistrements dans la source de données.
            adapter.Fill(table);

            //verifier si le jour de rendez-vous existe ou pas
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }





        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
    }
    

