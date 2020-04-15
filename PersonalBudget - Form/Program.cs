using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ContModel;
using NivelAccesDate;

namespace Aplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Formular form1 = new Formular();
            form1.Show();
            Application.Run();
        }
    }

    public class Formular : Form
    {
        IStocareData adminConturi = StocareFactory.GetAdministratorStocare();

        private Label lblNume;
        private Label lblPrenume;
        private Label lblVenit;
        private Label lblCheltuieli;
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtVenit;
        private TextBox txtCheltuieli;

        private Label lblInfo;
        private Button btnAdaugare;
        private Button btnAfisare;
        private const int LATIME_CONTROL = 150;
        private const int INALTIME_CONTROL = 20;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MAX = 15;

        public Formular()
        {
            this.Size = new System.Drawing.Size(600, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Administrare Conturi";

            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume: ";
            lblNume.BackColor = Color.Black;
            this.Controls.Add(lblNume);

            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume: ";
            lblPrenume.Top = DIMENSIUNE_PAS_Y;
            lblPrenume.BackColor = Color.Black;
            this.Controls.Add(lblPrenume);

            lblVenit = new Label();
            lblVenit.Width = LATIME_CONTROL;
            lblVenit.Text = "Venit: ";
            lblVenit.Top = DIMENSIUNE_PAS_Y * 2;
            lblVenit.BackColor = Color.Black;
            this.Controls.Add(lblVenit);

            lblCheltuieli = new Label();
            lblCheltuieli.Width = LATIME_CONTROL;
            lblCheltuieli.Text = "Cheltuieli: ";
            lblCheltuieli.Top = DIMENSIUNE_PAS_Y * 3;
            lblCheltuieli.BackColor = Color.Black;
            this.Controls.Add(lblCheltuieli);

            lblInfo = new Label();
            lblInfo.Width = LATIME_CONTROL * 3;
            lblInfo.Text = string.Empty;
            lblInfo.Top = DIMENSIUNE_PAS_Y * 5;
            lblInfo.Height = INALTIME_CONTROL * 2;
            lblInfo.BackColor = Color.Black;
            this.Controls.Add(lblInfo);



            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 0);
            this.Controls.Add(txtNume);


            txtPrenume = new TextBox();
            txtPrenume.Width = LATIME_CONTROL;
            txtPrenume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPrenume);

            txtVenit = new TextBox();
            txtVenit.Width = LATIME_CONTROL;
            txtVenit.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(txtVenit);

            txtCheltuieli = new TextBox();
            txtCheltuieli.Width = LATIME_CONTROL;
            txtCheltuieli.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 3);
            this.Controls.Add(txtCheltuieli);

            btnAdaugare = new Button();
            btnAdaugare.Width = LATIME_CONTROL;
            btnAdaugare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X,DIMENSIUNE_PAS_Y  *4);
            btnAdaugare.Text = "Adaugati Cont";
            this.Controls.Add(btnAdaugare);

            btnAfisare = new Button();
            btnAfisare.Width = LATIME_CONTROL;
            btnAfisare.Location = new System.Drawing.Point(0, DIMENSIUNE_PAS_Y * 4);
            btnAfisare.Text = "Afisati Conturi";
            this.Controls.Add(btnAfisare);


            btnAdaugare.Click += OnButtonAdaugaClicked;
            this.Controls.Add(btnAdaugare);

            //btnAfisare.Click += OnButtonAfisareClicked;
            //this.Controls.Add(btnAfisare);
        }

        private void OnButtonAdaugaClicked(object sender, EventArgs e)
        {
          
            int validare = Validare();

            lblNume.ForeColor = Color.LimeGreen;
            lblPrenume.ForeColor = Color.LimeGreen;
            lblVenit.ForeColor = Color.LimeGreen;
            lblCheltuieli.ForeColor = Color.LimeGreen;

            if (validare == 0)

            {
                int intVenit;
                Int32.TryParse(txtVenit.Text, out intVenit);
                int intCheltuieli;
                Int32.TryParse(txtVenit.Text, out intCheltuieli);
                Cont s = new Cont(txtNume.Text, txtPrenume.Text, intVenit,intCheltuieli);
                

                lblInfo.Text = s.ConversieLaSir();
                adminConturi.AddCont(s);

            }
            else
            {

                switch (validare)
                {
                    case 1:
                        lblNume.ForeColor = Color.Red;
                        break;
                    case 2:
                        lblPrenume.ForeColor = Color.Red;
                        break;
                    case 3:
                        lblVenit.ForeColor = Color.Red;
                        break;
                    case 4:
                        lblCheltuieli.ForeColor = Color.Red;
                        break;
                    default:
                        break;
                }

            }
        }

        /*private void OnButtonAfisareClicked(object sender, EventArgs e)
        {
            int nrConturi;
            Cont[] conturi = adminConturi.GetConturi(out nrConturi);
            if (nrConturi > 0)
            {
                Cont.IdUltimCont = conturi[nrConturi - 1].IdCont;
            }

            AfisareConturi(conturi, nrConturi);
        }
        */

        private int Validare()
        {
            int intVenit;
            Int32.TryParse(txtVenit.Text, out intVenit);
            int intCheltuieli;
            Int32.TryParse(txtVenit.Text, out intCheltuieli);
            if (txtNume.Text == string.Empty || txtNume.Text.Length > LUNGIME_MAX)
            {
                return 1;
            }
            else if (txtPrenume.Text == string.Empty || txtPrenume.Text.Length > LUNGIME_MAX)
            {
                return 2;
            }
            else if (txtVenit.Text == string.Empty || txtVenit.Text.Length > LUNGIME_MAX || intVenit < 0)
            {
                return 3;
            }
            else if (txtCheltuieli.Text == string.Empty || txtCheltuieli.Text.Length > LUNGIME_MAX || intCheltuieli < 0)
            {
                return 4;
            }

                return 0;
        }

    }
}
