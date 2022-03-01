using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultation_en_ligne
{
    
    class database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=consultation");

        //Fonction pour ouvrir la connection

        public void ouvrirConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //Fonction pour fermer la connection

        public void fermerConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //Fonction pour retourner la connection
        public MySqlConnection getConnection()
        {
           
            return connection;
        }






    }
}
