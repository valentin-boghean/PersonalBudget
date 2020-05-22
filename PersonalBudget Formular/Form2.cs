using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContModel;
using NivelAccesDate;

namespace PersonalBudget_Formular
{
    public partial class Form2 : Form
    {
        Cont s;
        public Form2(Cont cont)
        {
            s = cont;
            InitializeComponent();
        }
        IStocareData adminConturi = StocareFactory.GetAdministratorStocare();
        private void btnModifica_Click(object sender, EventArgs e)
        {
           
            if (s != null)
            {
                Console.WriteLine(s.Nume);
                s.Nume = txtNume.Text;
                s.Prenume = txtPrenume.Text;
                int intVenit;
                Int32.TryParse(txtVenit.Text, out intVenit);
                int intCheltuieli;
                Int32.TryParse(txtCheltuieli.Text, out intCheltuieli);
                s.Venit = intVenit;
                s.Cheltuieli = intCheltuieli;
               
                s.Sold = Convert.ToInt32(txtVenit.Text) - Convert.ToInt32(txtCheltuieli.Text);
                s.Durata = Int32.Parse(cmbDurata.Text);
                s.dataActualizare = DateTime.Now;
                adminConturi.UpdateCont(s);
            }
            else
            {
                lblInfo.Text = "Cont inexistent";
            }
        }
    }
}
