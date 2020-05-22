using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContModel;
using NivelAccesDate;
using System.Windows.Forms;

namespace PersonalBudget_Formular
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        IStocareData adminConturi = StocareFactory.GetAdministratorStocare();
        private void btnCauta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Cont> conturi = adminConturi.GetConturi();
            foreach( Cont cont in conturi)
            {
                if (DateTime.Compare(dateTimePicker1.Value,cont.dataActualizare) < 0 && DateTime.Compare(dateTimePicker2.Value,cont.dataActualizare)>0)
                    dataGridView1.DataSource = conturi.Select(c => new { c.IdCont, c.dataActualizare, c.Nume, c.Prenume,
                        c.Sold, c.Moneda }).ToList();
                dataGridView1.AutoResizeColumns();
            }
        }
    }
}
