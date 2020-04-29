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
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(43, 48);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(49, 17);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrenume.Location = new System.Drawing.Point(43, 80);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(72, 17);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblVenit
            // 
            this.lblVenit.AutoSize = true;
            this.lblVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVenit.Location = new System.Drawing.Point(43, 111);
            this.lblVenit.Name = "lblVenit";
            this.lblVenit.Size = new System.Drawing.Size(45, 17);
            this.lblVenit.TabIndex = 2;
            this.lblVenit.Text = "Venit";
            // 
            // lblCheltuieli
            // 
            this.lblCheltuieli.AutoSize = true;
            this.lblCheltuieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCheltuieli.Location = new System.Drawing.Point(43, 140);
            this.lblCheltuieli.Name = "lblCheltuieli";
            this.lblCheltuieli.Size = new System.Drawing.Size(75, 17);
            this.lblCheltuieli.TabIndex = 3;
            this.lblCheltuieli.Text = "Cheltuieli";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(169, 48);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(169, 80);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 22);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtVenit
            // 
            this.txtVenit.Location = new System.Drawing.Point(169, 111);
            this.txtVenit.Name = "txtVenit";
            this.txtVenit.Size = new System.Drawing.Size(100, 22);
            this.txtVenit.TabIndex = 6;
            // 
            // txtCheltuieli
            // 
            this.txtCheltuieli.Location = new System.Drawing.Point(169, 140);
            this.txtCheltuieli.Name = "txtCheltuieli";
            this.txtCheltuieli.Size = new System.Drawing.Size(100, 22);
            this.txtCheltuieli.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga.Location = new System.Drawing.Point(169, 196);
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
            this.btnSold.Location = new System.Drawing.Point(46, 196);
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
            this.btnAfisare.Location = new System.Drawing.Point(46, 250);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(101, 30);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(305, 48);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(449, 370);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

