﻿using System;
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
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fournisseurToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void atelierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void meubleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void enregistrerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Materiel().Show();
        }

        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Meuble().Show();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Piece().Show();
        }

        private void nouveauToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new Taxe().Show();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Approvisionnement().Show();
        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Fournisseur().Show();
        }

        private void créerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Client().Show();
        }

        private void créerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Commande().Show();
        }

        private void nouveauToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Atelier().Show();
        }

        private void nouveauToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Ouvrier().Show();
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Taches().Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
