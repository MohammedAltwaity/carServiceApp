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
    public partial class mainForm : Form
    {


       private List<Work> works = new List<Work>();
        public mainForm()
        {
            InitializeComponent();
            worksheetToolStripMenuItem.Enabled = false;
            paymentToolStripMenuItem.Enabled = false;
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.works.Clear();
            String fileName = openFileDialog.FileName;

            Loader loader = new Loader(new Parser());

            works = loader.LoadFile(fileName);

            EnableMenus();

        }




        //for the menus
        private void EnableMenus()
        {
            worksheetToolStripMenuItem.Enabled = true;
            paymentToolStripMenuItem.Enabled = true;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorksheetRegistration worksheetRegistration = new WorksheetRegistration();
            worksheetRegistration.CreateLayout(works);
            worksheetRegistration.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            MessageBox.Show(date.ToString() + "\n VLDGY0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }
    }
}
