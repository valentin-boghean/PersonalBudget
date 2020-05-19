using ContModel;
namespace PersonalBudget_Formular
{
    partial class Form1
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblVenit = new System.Windows.Forms.Label();
            this.lblCheltuieli = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtVenit = new System.Windows.Forms.TextBox();
            this.txtCheltuieli = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnSold = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.RichTextBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.rbtUSD = new System.Windows.Forms.RadioButton();
            this.lblValuta = new System.Windows.Forms.Label();
            this.rbtEUR = new System.Windows.Forms.RadioButton();
            this.rbtGBP = new System.Windows.Forms.RadioButton();
            this.rbtCAD = new System.Windows.Forms.RadioButton();
            this.rbtRON = new System.Windows.Forms.RadioButton();
            this.ckbEconomii = new System.Windows.Forms.CheckBox();
            this.lblEconomii = new System.Windows.Forms.Label();
            this.txtEconomii = new System.Windows.Forms.TextBox();
            this.btnResetare = new System.Windows.Forms.Button();
            this.listAfisare = new System.Windows.Forms.ListBox();
            this.cmbDurata = new System.Windows.Forms.ComboBox();
            this.Monede = new System.Windows.Forms.GroupBox();
            this.lblDurata = new System.Windows.Forms.Label();
            this.Monede.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(12, 48);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(49, 17);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrenume.Location = new System.Drawing.Point(12, 80);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(72, 17);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblVenit
            // 
            this.lblVenit.AutoSize = true;
            this.lblVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVenit.Location = new System.Drawing.Point(12, 111);
            this.lblVenit.Name = "lblVenit";
            this.lblVenit.Size = new System.Drawing.Size(45, 17);
            this.lblVenit.TabIndex = 2;
            this.lblVenit.Text = "Venit";
            // 
            // lblCheltuieli
            // 
            this.lblCheltuieli.AutoSize = true;
            this.lblCheltuieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCheltuieli.Location = new System.Drawing.Point(12, 140);
            this.lblCheltuieli.Name = "lblCheltuieli";
            this.lblCheltuieli.Size = new System.Drawing.Size(75, 17);
            this.lblCheltuieli.TabIndex = 3;
            this.lblCheltuieli.Text = "Cheltuieli";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(122, 48);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(187, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(122, 80);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(187, 22);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtVenit
            // 
            this.txtVenit.Location = new System.Drawing.Point(122, 111);
            this.txtVenit.Name = "txtVenit";
            this.txtVenit.Size = new System.Drawing.Size(187, 22);
            this.txtVenit.TabIndex = 6;
            // 
            // txtCheltuieli
            // 
            this.txtCheltuieli.Location = new System.Drawing.Point(122, 140);
            this.txtCheltuieli.Name = "txtCheltuieli";
            this.txtCheltuieli.Size = new System.Drawing.Size(187, 22);
            this.txtCheltuieli.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga.Location = new System.Drawing.Point(209, 296);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 30);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSold
            // 
            this.btnSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSold.Location = new System.Drawing.Point(89, 296);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(101, 30);
            this.btnSold.TabIndex = 9;
            this.btnSold.Text = "Afisare Sold";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAfisare.Location = new System.Drawing.Point(89, 342);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(101, 30);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(334, 45);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(455, 65);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitlu.Location = new System.Drawing.Point(89, 9);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(119, 19);
            this.lblTitlu.TabIndex = 12;
            this.lblTitlu.Text = "MENIU CONTURI";
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta.Location = new System.Drawing.Point(209, 342);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(100, 28);
            this.btnCauta.TabIndex = 13;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifica.Location = new System.Drawing.Point(89, 390);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(101, 28);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // rbtUSD
            // 
            this.rbtUSD.AutoSize = true;
            this.rbtUSD.Location = new System.Drawing.Point(6, 5);
            this.rbtUSD.Name = "rbtUSD";
            this.rbtUSD.Size = new System.Drawing.Size(58, 21);
            this.rbtUSD.TabIndex = 15;
            this.rbtUSD.TabStop = true;
            this.rbtUSD.Text = "USD";
            this.rbtUSD.UseVisualStyleBackColor = true;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValuta.Location = new System.Drawing.Point(12, 173);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(54, 17);
            this.lblValuta.TabIndex = 16;
            this.lblValuta.Text = "Valuta";
            // 
            // rbtEUR
            // 
            this.rbtEUR.AutoSize = true;
            this.rbtEUR.Location = new System.Drawing.Point(73, 5);
            this.rbtEUR.Name = "rbtEUR";
            this.rbtEUR.Size = new System.Drawing.Size(58, 21);
            this.rbtEUR.TabIndex = 17;
            this.rbtEUR.TabStop = true;
            this.rbtEUR.Text = "EUR";
            this.rbtEUR.UseVisualStyleBackColor = true;
            // 
            // rbtGBP
            // 
            this.rbtGBP.AutoSize = true;
            this.rbtGBP.Location = new System.Drawing.Point(137, 5);
            this.rbtGBP.Name = "rbtGBP";
            this.rbtGBP.Size = new System.Drawing.Size(58, 21);
            this.rbtGBP.TabIndex = 18;
            this.rbtGBP.TabStop = true;
            this.rbtGBP.Text = "GBP";
            this.rbtGBP.UseVisualStyleBackColor = true;
            // 
            // rbtCAD
            // 
            this.rbtCAD.AutoSize = true;
            this.rbtCAD.Location = new System.Drawing.Point(39, 32);
            this.rbtCAD.Name = "rbtCAD";
            this.rbtCAD.Size = new System.Drawing.Size(57, 21);
            this.rbtCAD.TabIndex = 19;
            this.rbtCAD.TabStop = true;
            this.rbtCAD.Text = "CAD";
            this.rbtCAD.UseVisualStyleBackColor = true;
            // 
            // rbtRON
            // 
            this.rbtRON.AutoSize = true;
            this.rbtRON.Location = new System.Drawing.Point(112, 32);
            this.rbtRON.Name = "rbtRON";
            this.rbtRON.Size = new System.Drawing.Size(60, 21);
            this.rbtRON.TabIndex = 20;
            this.rbtRON.TabStop = true;
            this.rbtRON.Text = "RON";
            this.rbtRON.UseVisualStyleBackColor = true;
            // 
            // ckbEconomii
            // 
            this.ckbEconomii.AutoSize = true;
            this.ckbEconomii.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbEconomii.Location = new System.Drawing.Point(138, 228);
            this.ckbEconomii.Name = "ckbEconomii";
            this.ckbEconomii.Size = new System.Drawing.Size(155, 21);
            this.ckbEconomii.TabIndex = 21;
            this.ckbEconomii.Text = "Adauga Economii";
            this.ckbEconomii.UseVisualStyleBackColor = true;
            this.ckbEconomii.CheckedChanged += new System.EventHandler(this.ckbEconomii_CheckedChanged);
            // 
            // lblEconomii
            // 
            this.lblEconomii.AutoSize = true;
            this.lblEconomii.Enabled = false;
            this.lblEconomii.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEconomii.Location = new System.Drawing.Point(15, 255);
            this.lblEconomii.Name = "lblEconomii";
            this.lblEconomii.Size = new System.Drawing.Size(73, 17);
            this.lblEconomii.TabIndex = 22;
            this.lblEconomii.Text = "Economii";
            // 
            // txtEconomii
            // 
            this.txtEconomii.Enabled = false;
            this.txtEconomii.Location = new System.Drawing.Point(121, 255);
            this.txtEconomii.Name = "txtEconomii";
            this.txtEconomii.Size = new System.Drawing.Size(186, 22);
            this.txtEconomii.TabIndex = 23;
            // 
            // btnResetare
            // 
            this.btnResetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetare.Location = new System.Drawing.Point(209, 390);
            this.btnResetare.Name = "btnResetare";
            this.btnResetare.Size = new System.Drawing.Size(100, 27);
            this.btnResetare.TabIndex = 24;
            this.btnResetare.Text = "Resetare";
            this.btnResetare.UseVisualStyleBackColor = true;
            this.btnResetare.Click += new System.EventHandler(this.btnResetare_Click);
            // 
            // listAfisare
            // 
            this.listAfisare.FormattingEnabled = true;
            this.listAfisare.ItemHeight = 16;
            this.listAfisare.Location = new System.Drawing.Point(334, 134);
            this.listAfisare.Name = "listAfisare";
            this.listAfisare.Size = new System.Drawing.Size(455, 324);
            this.listAfisare.TabIndex = 25;
            this.listAfisare.SelectedIndexChanged += new System.EventHandler(this.listAfisare_SelectedIndexChanged);
            // 
            // cmbDurata
            // 
            this.cmbDurata.FormattingEnabled = true;
            this.cmbDurata.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12",
            "24"});
            this.cmbDurata.Location = new System.Drawing.Point(121, 434);
            this.cmbDurata.Name = "cmbDurata";
            this.cmbDurata.Size = new System.Drawing.Size(188, 24);
            this.cmbDurata.TabIndex = 26;
            this.cmbDurata.SelectedIndexChanged += new System.EventHandler(this.cmbDurata_SelectedIndexChanged);
            // 
            // Monede
            // 
            this.Monede.Controls.Add(this.rbtRON);
            this.Monede.Controls.Add(this.rbtCAD);
            this.Monede.Controls.Add(this.rbtGBP);
            this.Monede.Controls.Add(this.rbtEUR);
            this.Monede.Controls.Add(this.rbtUSD);
            this.Monede.Location = new System.Drawing.Point(112, 166);
            this.Monede.Name = "Monede";
            this.Monede.Size = new System.Drawing.Size(196, 62);
            this.Monede.TabIndex = 27;
            this.Monede.TabStop = false;
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDurata.Location = new System.Drawing.Point(18, 440);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(100, 17);
            this.lblDurata.TabIndex = 28;
            this.lblDurata.Text = "Durata (luni)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 486);
            this.Controls.Add(this.lblDurata);
            this.Controls.Add(this.Monede);
            this.Controls.Add(this.cmbDurata);
            this.Controls.Add(this.listAfisare);
            this.Controls.Add(this.btnResetare);
            this.Controls.Add(this.txtEconomii);
            this.Controls.Add(this.lblEconomii);
            this.Controls.Add(this.ckbEconomii);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtCheltuieli);
            this.Controls.Add(this.txtVenit);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblCheltuieli);
            this.Controls.Add(this.lblVenit);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Monede.ResumeLayout(false);
            this.Monede.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblVenit;
        private System.Windows.Forms.Label lblCheltuieli;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtVenit;
        private System.Windows.Forms.TextBox txtCheltuieli;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.RichTextBox lblInfo;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.RadioButton rbtUSD;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.RadioButton rbtEUR;
        private System.Windows.Forms.RadioButton rbtGBP;
        private System.Windows.Forms.RadioButton rbtCAD;
        private System.Windows.Forms.RadioButton rbtRON;
        private System.Windows.Forms.CheckBox ckbEconomii;
        private System.Windows.Forms.Label lblEconomii;
        private System.Windows.Forms.TextBox txtEconomii;
        private System.Windows.Forms.Button btnResetare;
        private System.Windows.Forms.ListBox listAfisare;
        private System.Windows.Forms.ComboBox cmbDurata;
        private System.Windows.Forms.GroupBox Monede;
        private System.Windows.Forms.Label lblDurata;
    }
}

