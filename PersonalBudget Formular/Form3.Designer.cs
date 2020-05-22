namespace PersonalBudget_Formular
{
    partial class Form3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDeLa = new System.Windows.Forms.Label();
            this.lblPanaLa = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(67, 132);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lblDeLa
            // 
            this.lblDeLa.AutoSize = true;
            this.lblDeLa.Location = new System.Drawing.Point(67, 26);
            this.lblDeLa.Name = "lblDeLa";
            this.lblDeLa.Size = new System.Drawing.Size(46, 17);
            this.lblDeLa.TabIndex = 2;
            this.lblDeLa.Text = "De La";
            // 
            // lblPanaLa
            // 
            this.lblPanaLa.AutoSize = true;
            this.lblPanaLa.Location = new System.Drawing.Point(67, 100);
            this.lblPanaLa.Name = "lblPanaLa";
            this.lblPanaLa.Size = new System.Drawing.Size(61, 17);
            this.lblPanaLa.TabIndex = 3;
            this.lblPanaLa.Text = "Pana La";
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCauta.Location = new System.Drawing.Point(67, 211);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(200, 28);
            this.btnCauta.TabIndex = 14;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 373);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblPanaLa);
            this.Controls.Add(this.lblDeLa);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblDeLa;
        private System.Windows.Forms.Label lblPanaLa;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}