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
    public partial class Piece : Form
    {
        OleDbDataAdapter adp = new OleDbDataAdapter();
        DataTable data = new DataTable();
        BindingSource bs = new BindingSource();
        OleDbCommand Cmd = new OleDbCommand();
        public Piece()
        {
            InitializeComponent();
            ChargerData();

        }
        public void ChargerData()
        {
            adp = new OleDbDataAdapter();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd = Program.Con.CreateCommand();
            data = new DataTable();
            Cmd.CommandText = "SELECT * FROM Piece";
            adp.SelectCommand = Cmd;
            adp.Fill(data);
            adp.FillSchema(data, SchemaType.Source);
        }
        public void LierDonnees()
        {
            bs.DataSource = data;
            dtTch.DataSource = bs;
            txtcodeN.DataBindings.Add("Text", bs, "code");
            /*
            oCmd = cnn.CreateCommand
oCmd.CommandText = "sp_allsum"
adapter.SelectCommand = oCmd 
adapter.Fill(ds)
            *
            */

        }
        private void Piece_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
