namespace UTILISATEUR
{
    partial class Piece
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
            this.btnadd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLibN = new System.Windows.Forms.TextBox();
            this.txtcodeN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbmatuseN = new System.Windows.Forms.ComboBox();
            this.dateN = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.gbM = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmatuseM = new System.Windows.Forms.ComboBox();
            this.dateM = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLibM = new System.Windows.Forms.TextBox();
            this.txtcodeM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexitTch = new System.Windows.Forms.Button();
            this.btncancelTch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndelTch = new System.Windows.Forms.Button();
            this.btneditTch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbmeublDestN = new System.Windows.Forms.ComboBox();
            this.cmbmeublDestM = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbM.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(31, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 32);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "&Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Date de Fabrication";
            // 
            // txtLibN
            // 
            this.txtLibN.Location = new System.Drawing.Point(209, 126);
            this.txtLibN.Multiline = true;
            this.txtLibN.Name = "txtLibN";
            this.txtLibN.Size = new System.Drawing.Size(255, 26);
            this.txtLibN.TabIndex = 5;
            // 
            // txtcodeN
            // 
            this.txtcodeN.Location = new System.Drawing.Point(209, 78);
            this.txtcodeN.Multiline = true;
            this.txtcodeN.Name = "txtcodeN";
            this.txtcodeN.Size = new System.Drawing.Size(255, 30);
            this.txtcodeN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvelle Pièce";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtTch
            // 
            this.dtTch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTch.Location = new System.Drawing.Point(12, 529);
            this.dtTch.Name = "dtTch";
            this.dtTch.Size = new System.Drawing.Size(1068, 181);
            this.dtTch.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbmeublDestN);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbmatuseN);
            this.groupBox1.Controls.Add(this.dateN);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLibN);
            this.groupBox1.Controls.Add(this.txtcodeN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 318);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Meuble Destiné";
            // 
            // cmbmatuseN
            // 
            this.cmbmatuseN.FormattingEnabled = true;
            this.cmbmatuseN.Location = new System.Drawing.Point(209, 173);
            this.cmbmatuseN.Name = "cmbmatuseN";
            this.cmbmatuseN.Size = new System.Drawing.Size(255, 29);
            this.cmbmatuseN.TabIndex = 9;
            this.cmbmatuseN.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateN
            // 
            this.dateN.Location = new System.Drawing.Point(209, 270);
            this.dateN.Name = "dateN";
            this.dateN.Size = new System.Drawing.Size(255, 29);
            this.dateN.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libelle";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(172, 24);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 33);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "&Annuler";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // gbM
            // 
            this.gbM.Controls.Add(this.cmbmeublDestM);
            this.gbM.Controls.Add(this.label12);
            this.gbM.Controls.Add(this.label6);
            this.gbM.Controls.Add(this.cmbmatuseM);
            this.gbM.Controls.Add(this.dateM);
            this.gbM.Controls.Add(this.label10);
            this.gbM.Controls.Add(this.txtLibM);
            this.gbM.Controls.Add(this.txtcodeM);
            this.gbM.Controls.Add(this.label7);
            this.gbM.Controls.Add(this.label8);
            this.gbM.Controls.Add(this.label5);
            this.gbM.Location = new System.Drawing.Point(531, 108);
            this.gbM.Name = "gbM";
            this.gbM.Size = new System.Drawing.Size(551, 318);
            this.gbM.TabIndex = 21;
            this.gbM.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Meuble Destiné";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbmatuseM
            // 
            this.cmbmatuseM.FormattingEnabled = true;
            this.cmbmatuseM.Location = new System.Drawing.Point(212, 165);
            this.cmbmatuseM.Name = "cmbmatuseM";
            this.cmbmatuseM.Size = new System.Drawing.Size(254, 29);
            this.cmbmatuseM.TabIndex = 15;
            // 
            // dateM
            // 
            this.dateM.Location = new System.Drawing.Point(212, 268);
            this.dateM.Name = "dateM";
            this.dateM.Size = new System.Drawing.Size(254, 29);
            this.dateM.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Date de Fabrication";
            // 
            // txtLibM
            // 
            this.txtLibM.Location = new System.Drawing.Point(212, 121);
            this.txtLibM.Multiline = true;
            this.txtLibM.Name = "txtLibM";
            this.txtLibM.Size = new System.Drawing.Size(254, 26);
            this.txtLibM.TabIndex = 11;
            // 
            // txtcodeM
            // 
            this.txtcodeM.Location = new System.Drawing.Point(212, 78);
            this.txtcodeM.Multiline = true;
            this.txtcodeM.Name = "txtcodeM";
            this.txtcodeM.Size = new System.Drawing.Size(254, 23);
            this.txtcodeM.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Libelle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modifier la Pièce";
            // 
            // btnexitTch
            // 
            this.btnexitTch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitTch.Location = new System.Drawing.Point(320, 26);
            this.btnexitTch.Name = "btnexitTch";
            this.btnexitTch.Size = new System.Drawing.Size(89, 31);
            this.btnexitTch.TabIndex = 9;
            this.btnexitTch.Text = "&Quitter";
            this.btnexitTch.UseVisualStyleBackColor = true;
            // 
            // btncancelTch
            // 
            this.btncancelTch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelTch.Location = new System.Drawing.Point(140, 20);
            this.btncancelTch.Name = "btncancelTch";
            this.btncancelTch.Size = new System.Drawing.Size(95, 37);
            this.btncancelTch.TabIndex = 1;
            this.btncancelTch.Text = "&Annuler";
            this.btncancelTch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btndelTch);
            this.groupBox4.Controls.Add(this.btncancelTch);
            this.groupBox4.Controls.Add(this.btneditTch);
            this.groupBox4.Location = new System.Drawing.Point(549, 432);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 70);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // btndelTch
            // 
            this.btndelTch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelTch.Location = new System.Drawing.Point(266, 20);
            this.btndelTch.Name = "btndelTch";
            this.btndelTch.Size = new System.Drawing.Size(99, 41);
            this.btndelTch.TabIndex = 2;
            this.btndelTch.Text = "&Supprimer";
            this.btndelTch.UseVisualStyleBackColor = true;
            // 
            // btneditTch
            // 
            this.btneditTch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditTch.Location = new System.Drawing.Point(22, 21);
            this.btneditTch.Name = "btneditTch";
            this.btneditTch.Size = new System.Drawing.Size(92, 40);
            this.btneditTch.TabIndex = 0;
            this.btneditTch.Text = "&Modifier";
            this.btneditTch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnexitTch);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.btncancel);
            this.groupBox2.Location = new System.Drawing.Point(24, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 70);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Materiel Utilisé";
            // 
            // cmbmeublDestN
            // 
            this.cmbmeublDestN.FormattingEnabled = true;
            this.cmbmeublDestN.Location = new System.Drawing.Point(209, 223);
            this.cmbmeublDestN.Name = "cmbmeublDestN";
            this.cmbmeublDestN.Size = new System.Drawing.Size(257, 29);
            this.cmbmeublDestN.TabIndex = 12;
            // 
            // cmbmeublDestM
            // 
            this.cmbmeublDestM.FormattingEnabled = true;
            this.cmbmeublDestM.Location = new System.Drawing.Point(212, 215);
            this.cmbmeublDestM.Name = "cmbmeublDestM";
            this.cmbmeublDestM.Size = new System.Drawing.Size(257, 29);
            this.cmbmeublDestM.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Materiel Utilisé";
            // 
            // Piece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 734);
            this.Controls.Add(this.dtTch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbM);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Piece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piece";
            this.Load += new System.EventHandler(this.Piece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbM.ResumeLayout(false);
            this.gbM.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLibN;
        private System.Windows.Forms.TextBox txtcodeN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtTch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox gbM;
        private System.Windows.Forms.TextBox txtLibM;
        private System.Windows.Forms.TextBox txtcodeM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexitTch;
        private System.Windows.Forms.Button btncancelTch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndelTch;
        private System.Windows.Forms.Button btneditTch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbmatuseN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmatuseM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbmeublDestN;
        private System.Windows.Forms.ComboBox cmbmeublDestM;
        private System.Windows.Forms.Label label12;
    }
}