using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace UTILISATEUR
{
    public partial class Taxe : Form
    {
        OleDbDataAdapter adp;
        DataTable data;
        BindingSource bs;
        public Taxe()
        {
            InitializeComponent();
            try { 
                data = new DataTable();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Taxe");
                adp = new OleDbDataAdapter(cmd.ToString(), Program.Con);
                adp.Fill(data);
                adp.FillSchema(data, SchemaType.Source);
                bs = new BindingSource();
                bs.DataSource = data;
                dataGridView1.DataSource = bs;
                txtcodeN.DataBindings.Add("text", bs, "code");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtcodeN.Text = "";
            txtPourN.Text = "";
            cmbMotN.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if((txtcodeN.Text == "") || (txtPourN.Text == "") || (cmbMotN.Text == ""))
            {

            }
            else
            {

            }
        }

        private void Taxe_Load(object sender, EventArgs e)
        {

        }
    }
}
