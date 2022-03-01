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
    public partial class symptomes : Form
    {



        void populate()
        {

            database db = new database();

            MySqlConnection ss = db.getConnection();
            using (ss)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id, symptome FROM symptomes", ss))
            {
                DataTable s = new DataTable();
                adapter.Fill(s);
                checkedListBox1.DataSource = s;
                checkedListBox1.ValueMember = "symptome";


            }
        }


        public symptomes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void symptomes_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {


           
           
            
                if (checkedListBox1.GetItemCheckState(0)  == CheckState.Checked && checkedListBox1.GetItemCheckState(1)== CheckState.Checked || checkedListBox1.GetItemCheckState(2) == CheckState.Checked || checkedListBox1.GetItemCheckState(3) == CheckState.Checked || checkedListBox1.GetItemCheckState(4) == CheckState.Checked &&  checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
                {
                    MessageBox.Show("Utiliser le reference A11 dans le champ ci dessous pour savoir plus sur votre maladie et le traitement");
                    this.Hide();
                    InfoMaladie menumaladie = new InfoMaladie();
                    menumaladie.Show();

                }
                
               
                else if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked || checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
                {
                  MessageBox.Show("Utiliser le reference M11 dans le champ ci dessous pour savoir plus sur votre maladie et le traitement");
                  this.Hide();
                  InfoMaladie menumaladie = new InfoMaladie();
                  menumaladie.Show();

                }
                else if (checkedListBox1.GetItemCheckState(8) == CheckState.Checked || checkedListBox1.GetItemCheckState(9) == CheckState.Checked || checkedListBox1.GetItemCheckState(10) == CheckState.Checked && checkedListBox1.GetItemCheckState(11) == CheckState.Checked)


                {
                 MessageBox.Show("Utiliser le reference S11 dans le champ ci dessous pour savoir plus sur votre maladie et le traitement");
                 this.Hide();
                 InfoMaladie menumaladie = new InfoMaladie();
                 menumaladie.Show();
                }
                else if (checkedListBox1.GetItemCheckState(10) == CheckState.Checked && checkedListBox1.GetItemCheckState(12) == CheckState.Checked || checkedListBox1.GetItemCheckState(13) == CheckState.Checked && checkedListBox1.GetItemCheckState(14) == CheckState.Checked && checkedListBox1.GetItemCheckState(15) == CheckState.Checked)
                {
                MessageBox.Show("Utiliser le reference B11 dans le champ ci dessous pour savoir plus sur votre maladie et le traitement");
                this.Hide();
                InfoMaladie menumaladie = new InfoMaladie();
                menumaladie.Show();
                }    
                else if (checkedListBox1.GetItemCheckState(16) == CheckState.Checked || checkedListBox1.GetItemCheckState(17) == CheckState.Checked || checkedListBox1.GetItemCheckState(18) == CheckState.Checked && checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
                {
                MessageBox.Show("Utiliser le reference C11 dans le champ ci dessous pour savoir plus sur votre maladie et le traitement");
                this.Hide();
                InfoMaladie menumaladie = new InfoMaladie();
                menumaladie.Show();
                }
                else
                {
                MessageBox.Show("Choix Manquants");
                }



        }
    }
}
