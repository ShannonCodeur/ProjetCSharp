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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {


        }

        private void txtidfour_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtidfour.Text == "")
            {
                errorProvider1.SetError(txtidfour, "Veuillez remplir ce champs ");
            }
        }

        private void txtidfour_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
