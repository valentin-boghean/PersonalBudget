using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ContModel;
using NivelAccesDate;

namespace PersonalBudget_Formular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        IStocareData adminConturi = StocareFactory.GetAdministratorStocare();
        private const int LATIME_CONTROL = 150;
        private const int INALTIME_CONTROL = 20;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MAX = 15;
        private void btnSold_Click(object sender, EventArgs e)
        {
            Cont c = new Cont(txtNume.Text, txtPrenume.Text, Convert.ToInt32(txtVenit.Text), Convert.ToInt32(txtCheltuieli.Text));
          
            lblInfo.Text = "Soldul contului curent este: " + Convert.ToString(c.Sold);
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            lblInfo.Text = string.Empty;
            ArrayList conturi;
            conturi = adminConturi.GetConturi();
            Cont.IdUltimCont = ((Cont)conturi[conturi.Count - 1]).IdCont;

            var header = string.Format("{0,-2}{1,10}{2,10}{3,10}{4,10}{5,15}{6,15}", "ID", "Nume", "Prenume", "Sold", "Valuta", "Venit/Luna", "Cheltuieli");
            lblInfo.Text = lblInfo.Text + header;
            lblInfo.Text = lblInfo.Text + "\n-----------------------------------------------------------------------------------------------------------";

            foreach (Cont cont in conturi)
                lblInfo.Text = lblInfo.Text + "\n" + cont.ConversieLaSir();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Validare();
            if (lblNume.ForeColor == Color.Red || lblPrenume.ForeColor == Color.Red || lblVenit.ForeColor == Color.Red || lblCheltuieli.ForeColor == Color.Red)
                lblInfo.Text = "Datele nu sunt valide";
            else

            {
                int intVenit;
                Int32.TryParse(txtVenit.Text, out intVenit);
                int intCheltuieli;
                Int32.TryParse(txtCheltuieli.Text, out intCheltuieli);
                Cont s = new Cont(txtNume.Text, txtPrenume.Text, intVenit, intCheltuieli);

                lblInfo.Text = s.ConversieLaSir();
                Cont.IdUltimCont++;
                adminConturi.AddCont(s);
            }
        }






        private void Validare()
        {
            lblNume.ForeColor = Color.LimeGreen;
            lblPrenume.ForeColor = Color.LimeGreen;
            lblVenit.ForeColor = Color.LimeGreen;
            lblCheltuieli.ForeColor = Color.LimeGreen;

            int intVenit;
            Int32.TryParse(txtVenit.Text, out intVenit);
            int intCheltuieli;
            Int32.TryParse(txtVenit.Text, out intCheltuieli);
            if (txtNume.Text == string.Empty || txtNume.Text.Length > LUNGIME_MAX)
            {
                lblNume.ForeColor = Color.Red;
            }
            if (txtPrenume.Text == string.Empty || txtPrenume.Text.Length > LUNGIME_MAX)
            {
                lblPrenume.ForeColor = Color.Red;
            }
            if (txtVenit.Text == string.Empty || txtVenit.Text.Length > LUNGIME_MAX || intVenit < 0)
            {
                lblVenit.ForeColor = Color.Red;
            }
            if (txtCheltuieli.Text == string.Empty || txtCheltuieli.Text.Length > LUNGIME_MAX || intCheltuieli < 0)
            {
                lblCheltuieli.ForeColor = Color.Red;
            }

        }
    }
}