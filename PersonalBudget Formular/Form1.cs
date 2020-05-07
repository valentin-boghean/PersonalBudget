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
            Cont c = adminConturi.GetCont(txtNume.Text, txtPrenume.Text);
            c.Venit = Convert.ToInt32(txtVenit.Text);
            c.Cheltuieli = Convert.ToInt32(txtCheltuieli.Text);

            lblInfo.Text = "Soldul contului curent este: " + Convert.ToString(c.Sold);
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            lblInfo.Text = string.Empty;
            ArrayList conturi;
            conturi = adminConturi.GetConturi();
         

            var header = string.Format("{0,-2}{1,10}{2,10}{3,10}{4,10}{5,15}{6,15}", "ID", "Nume", "Prenume", "Sold", "Valuta", "Venit/Luna", "Cheltuieli");
            lblInfo.Text = lblInfo.Text + header;
            lblInfo.Text = lblInfo.Text + "\n-----------------------------------------------------------------------------------------------------------";

            foreach (Cont cont in conturi)
                lblInfo.Text = lblInfo.Text + "\n" + cont.ConversieLaSir();
            lblInfo.ForeColor = Color.Black;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Validare();
            if (lblNume.ForeColor == Color.Red || lblPrenume.ForeColor == Color.Red || lblVenit.ForeColor == Color.Red ||
                lblCheltuieli.ForeColor == Color.Red || lblValuta.ForeColor == Color.Red || lblEconomii.ForeColor == Color.Red)
            {
                lblInfo.Text = "Datele nu sunt valide";
                lblInfo.ForeColor = Color.Red;
            }
            else

            {
                //setare cont
                int intVenit;
                Int32.TryParse(txtVenit.Text, out intVenit);
                int intCheltuieli;
                Int32.TryParse(txtCheltuieli.Text, out intCheltuieli);
                Cont s = new Cont(txtNume.Text, txtPrenume.Text, intVenit, intCheltuieli);
             
                //Setare valuta
                if (rbtCAD.Checked)
                    s.Moneda = Valuta.CAD;
                if (rbtUSD.Checked)
                    s.Moneda = Valuta.USD;
                if (rbtEUR.Checked)
                    s.Moneda = Valuta.EUR;
                if (rbtGBP.Checked)
                    s.Moneda = Valuta.GBP;
                if (rbtRON.Checked)
                    s.Moneda = Valuta.RON;
                if (ckbEconomii.Checked)
                {
                    int eco;
                    int.TryParse(txtEconomii.Text, out eco);
                    s.Economii = eco;
                }
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Contul a fost adaugat";

                adminConturi.AddCont(s);
            }
        }
        private void Validare()
        {
            lblNume.ForeColor = Color.LimeGreen;
            lblPrenume.ForeColor = Color.LimeGreen;
            lblVenit.ForeColor = Color.LimeGreen;
            lblCheltuieli.ForeColor = Color.LimeGreen;
            lblValuta.ForeColor = Color.LimeGreen;
            lblEconomii.ForeColor = Color.LimeGreen;

            int intVenit;
            Int32.TryParse(txtVenit.Text, out intVenit);
            int intCheltuieli;
            Int32.TryParse(txtCheltuieli.Text, out intCheltuieli);
            if (txtNume.Text == string.Empty || txtNume.Text.Length > LUNGIME_MAX || Int32.TryParse(txtNume.Text, out _))
            {
                lblNume.ForeColor = Color.Red;
            }
            if (txtPrenume.Text == string.Empty || txtPrenume.Text.Length > LUNGIME_MAX || Int32.TryParse(txtPrenume.Text, out _))
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
            if (!rbtCAD.Checked && !rbtUSD.Checked && !rbtEUR.Checked && !rbtGBP.Checked && !rbtRON.Checked)
                lblValuta.ForeColor = Color.Red;
            if (!int.TryParse(txtEconomii.Text, out _) && !(txtEconomii.Text == string.Empty))
              lblEconomii.ForeColor = Color.Red;

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            Cont s = adminConturi.GetCont(txtNume.Text, txtPrenume.Text);
            if (s != null)
            {
                lblInfo.Text = s.ConversieLaSir();
            }
            else
                lblInfo.Text = "Nu s-a gasit studentul";
            if (txtNume.Enabled == true && txtPrenume.Enabled == true)
            {
                txtNume.Enabled = false;
                txtPrenume.Enabled = false;
            }
            else
            {
                txtNume.Enabled = true;
                txtPrenume.Enabled = true;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Cont s = adminConturi.GetCont(txtNume.Text, txtPrenume.Text);
            if (s != null)
            {
                int intVenit;
                Int32.TryParse(txtVenit.Text, out intVenit);
                int intCheltuieli;
                Int32.TryParse(txtCheltuieli.Text, out intCheltuieli);
                s.Venit = intVenit;
                s.Cheltuieli = intCheltuieli;
                lblInfo.Text = s.ConversieLaSir();
                s.Sold = Convert.ToInt32(txtVenit.Text) - Convert.ToInt32(txtCheltuieli.Text);
                
                adminConturi.UpdateCont(s);
            }
            else
            {
                lblInfo.Text = "Cont inexistent";
            }
        }

        private void ResetareControale()
        {
            lblEconomii.Enabled = false;
            txtEconomii.Enabled = false;
        }

        private void ckbEconomii_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEconomii.Checked)
            {
                lblEconomii.Enabled = true;
                txtEconomii.Enabled = true;          
            }  
            else
            {
                lblEconomii.Enabled = false;
                txtEconomii.Enabled = false;
            }
        }

        private void btnResetare_Click(object sender, EventArgs e)
        {
            ResetareControale();
        }
    }
}