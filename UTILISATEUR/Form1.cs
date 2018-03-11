using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTILISATEUR
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmotpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtmotpass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Vider();
        }
        public void Vider()
        {
            txtuser.Text = "";
            txtmotpass.Text = "";
        }

        private void btnvalid_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Veuillez Remplir le Champ");
            }
            else if (txtmotpass.Text == "isele")
            {
                MessageBox.Show("Veuillez Remplir le Champ");
            }

            if ((txtuser.Text != "") && (txtmotpass.Text != ""))
            {
                if ((txtuser.Text == "Admin") && (txtmotpass.Text == "Admin"))
                {
                    new Menu().Show();
                    Close();
                }
                else
                {
                    Vider();
                }

            }

        }
    }
}
