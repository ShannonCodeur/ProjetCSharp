namespace UTILISATEUR
{
    partial class Fournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adressfour = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.nomfour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadressfour = new System.Windows.Forms.TextBox();
            this.txtprenomfour = new System.Windows.Forms.TextBox();
            this.txtnomfour = new System.Windows.Forms.TextBox();
            this.txtidfour = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adressfour);
            this.groupBox1.Controls.Add(this.lblprenom);
            this.groupBox1.Controls.Add(this.nomfour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtadressfour);
            this.groupBox1.Controls.Add(this.txtprenomfour);
            this.groupBox1.Controls.Add(this.txtnomfour);
            this.groupBox1.Controls.Add(this.txtidfour);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                             Nouveau Fournisseur";
            // 
            // adressfour
            // 
            this.adressfour.AutoSize = true;
            this.adressfour.Location = new System.Drawing.Point(15, 197);
            this.adressfour.Name = "adressfour";
            this.adressfour.Size = new System.Drawing.Size(59, 19);
            this.adressfour.TabIndex = 20;
            this.adressfour.Text = "Adresse";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(15, 147);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(56, 19);
            this.lblprenom.TabIndex = 19;
            this.lblprenom.Text = "Prénom";
            // 
            // nomfour
            // 
            this.nomfour.AutoSize = true;
            this.nomfour.Location = new System.Drawing.Point(15, 101);
            this.nomfour.Name = "nomfour";
            this.nomfour.Size = new System.Drawing.Size(40, 19);
            this.nomfour.TabIndex = 18;
            this.nomfour.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Identifiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtadressfour
            // 
            this.txtadressfour.Location = new System.Drawing.Point(134, 194);
            this.txtadressfour.Multiline = true;
            this.txtadressfour.Name = "txtadressfour";
            this.txtadressfour.Size = new System.Drawing.Size(211, 28);
            this.txtadressfour.TabIndex = 16;
            // 
            // txtprenomfour
            // 
            this.txtprenomfour.Location = new System.Drawing.Point(134, 147);
            this.txtprenomfour.Multiline = true;
            this.txtprenomfour.Name = "txtprenomfour";
            this.txtprenomfour.Size = new System.Drawing.Size(211, 27);
            this.txtprenomfour.TabIndex = 15;
            // 
            // txtnomfour
            // 
            this.txtnomfour.Location = new System.Drawing.Point(134, 101);
            this.txtnomfour.Multiline = true;
            this.txtnomfour.Name = "txtnomfour";
            this.txtnomfour.Size = new System.Drawing.Size(211, 28);
            this.txtnomfour.TabIndex = 14;
            // 
            // txtidfour
            // 
            this.txtidfour.Location = new System.Drawing.Point(134, 49);
            this.txtidfour.Multiline = true;
            this.txtidfour.Name = "txtidfour";
            this.txtidfour.Size = new System.Drawing.Size(211, 28);
            this.txtidfour.TabIndex = 13;
            this.txtidfour.TextChanged += new System.EventHandler(this.txtidfour_TextChanged);
            this.txtidfour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidfour_KeyPress);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(158, 264);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(82, 33);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "&Annuler";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(19, 264);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(82, 33);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "&Enregistrer";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.cancel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(246, 25);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 36);
            this.delete.TabIndex = 2;
            this.delete.Text = "&Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(134, 25);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 36);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "&Annuler";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fournisseur";
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.Fournisseur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label adressfour;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label nomfour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadressfour;
        private System.Windows.Forms.TextBox txtprenomfour;
        private System.Windows.Forms.TextBox txtnomfour;
        private System.Windows.Forms.TextBox txtidfour;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
    }
}