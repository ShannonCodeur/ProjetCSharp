using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace UTILISATEUR
{
    static class Program
    {
        public static OleDbConnection Con;
        public static OleDbCommand Cmd;    
   
        [STAThread]
        static void Main(string[] args)
        {
            connexion_bd();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Connexion());
            Application.Run(new Connexion());
            
        }
        public static void connexion_bd()
        {
            OleDbConnection Con = new OleDbConnection();
            Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ISELE/Documents/Projet_CSharp.mdb";
            Con.Open();
            MessageBox.Show("Bonne Connexion");
        }
    }
}
