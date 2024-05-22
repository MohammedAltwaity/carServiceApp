using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLDGY0
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

            serviceCost.ForeColor = Color.Green;
            total.ForeColor = Color.Red;
            workCount.Text = StateOfTheWorksheetRegistration.numberOfWork.ToString();
            worksheetCount.Text = StateOfTheWorksheetRegistration.numberOfWorksheets.ToString();
            materialCost.Text = StateOfTheWorksheetRegistration.materialCost.ToString() + " FT";
            serviceCost.Text = StateOfTheWorksheetRegistration.serviceCost.ToString() + " FT";
            total.Text = (StateOfTheWorksheetRegistration.serviceCost +StateOfTheWorksheetRegistration.materialCost).ToString() + " Ft";
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            StateOfTheWorksheetRegistration.materialCost = 0;
            StateOfTheWorksheetRegistration.serviceCost = 0;
            StateOfTheWorksheetRegistration.totalToPay = 0;
            StateOfTheWorksheetRegistration.numberOfWork = 0;
            StateOfTheWorksheetRegistration.numberOfWorksheets = 0;
        }
    }
}
