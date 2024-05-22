using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLDGY0
{
    public partial class WorksheetRegistration : Form
    {



        private List<Work> works = new List<Work>();
        private List<Label> labels = new List<Label>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        public bool IsRegistered { get; set; }
        // Controls
        private const int left = 10, top = 10, disY = 25, right = 20, xBoxSize = 250, yBoxdistance = 60, xSize = 40, ySize = 30;




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }





        public decimal  materialCost = 0, timeCost = 0;


        
        //Ask a qustion before closing the form;
        private void WorksheetRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.IsRegistered != true)
            {
                DialogResult result = MessageBox.Show("Do you want to close without saving worksheet? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

           

        }

        private void materialCostValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Calculation();
            IsRegistered = true;
            this.Close();
        }

        public int numberOfWorks = 0;
        public int numberOfWorksheets = 0;



        public WorksheetRegistration()
        {
            InitializeComponent();
        }

        private void WorksheetRegistration_Load(object sender, EventArgs e)
        {

        }





        internal void CreateLayout(List<Work> works)
        {


            this.works = works;
            panel1.Controls.Clear();
            checkBoxes.Clear();
            labels.Clear();


            for (int i = 0; i < works.Count; i++)
            {



                // Name of Service 
                Label label = new Label();
                label.Text = works[i].Name;
                label.Size = new Size(100, 50);
                label.Location = new Point(left, top + (i * yBoxdistance));


                // Material Cost 
                Label label1 = new Label();
                label1.Text = works[i].MaterialCosts.ToString()+" FT";
                label1.Size = new Size(100, 50);
                label1.Location = new Point(left + 150, label.Location.Y);


                // required Time
                Label label2 = new Label();


                string requiredTime = (works[i].RequiredTimeMinutes >= 60)? works[i].TotalServiceTimeHours.ToString() + "H " + works[i].RemainingServiceTimeMinutes + "M": works[i].TotalServiceTimeMinutes.ToString()+"M";

                label2.Text = requiredTime;
                label2.Size = new Size(100, 50);
                label2.Location = new Point(left + 10 * disY, label.Location.Y);

                // total cost
                Label TotalCostLabel = new Label();
                TotalCostLabel.Name = "lblCost" + i;
                decimal totalCost = 0;
                decimal serviceCost = 0;


                serviceCost = (works[i].TotalServiceTimeHours * 1500);
                serviceCost += (works[i].RemainingServiceTimeMinutes > 30) ? 1500 : (1500/2);


                totalCost = works[i].MaterialCosts + serviceCost;
                TotalCostLabel.Tag = totalCost.ToString() + "FT";
                TotalCostLabel.Text = "";
                //MessageBox.Show(label.Location.Y.ToString());
                TotalCostLabel.Size = new Size(100, 50);
                TotalCostLabel.Location = new Point(left + 20 * disY + 100, label.Location.Y);


                // checkBoxes
                CheckBox checkBox = new CheckBox();
                checkBox.Size = new Size(xBoxSize, ySize);
                checkBox.CheckedChanged += new EventHandler(selectCheck);

                checkBox.Location = new Point(left + 10 * disY + 100, label.Location.Y);




                panel1.Controls.Add(label);
                panel1.Controls.Add(label1);
                panel1.Controls.Add(checkBox);
                panel1.Controls.Add(label2);
                panel1.Controls.Add(TotalCostLabel);

                labels.Add(label);
                labels.Add(label1);
                labels.Add(label2);
                labels.Add(TotalCostLabel);
                checkBoxes.Add(checkBox);

             

            }
        }





       

        private void selectCheck(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            decimal materialCost = 0, timeCost = 0;
            for(int i = 0; i< works.Count; i++)
            {
                Label label = (Label)panel1.Controls.Find("lblCost" + i, true)[0];
                if (checkBoxes[i].Checked)
                {
                    materialCost += works[i].MaterialCosts;

                    int checkRemainingTimeInMinutes = (works[i].RemainingServiceTimeMinutes > 30) ? 1500 : (1500 / 2);
                    timeCost += (works[i].TotalServiceTimeHours * 1500) + checkRemainingTimeInMinutes ;


                   
                    label.Text = label.Tag + "";
                }
                else
                {
                    label.Text = "";   
                }

 
            }

            materialCostValue.Text = materialCost.ToString() + " FT";
            timeCostValue.Text = timeCost.ToString()+" FT";


        }









      
   


        public void Calculation()
        {
            this.numberOfWorksheets++;

            for (int  i = 0; i < works.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    this.numberOfWorks++;
                    this.materialCost += works[i].MaterialCosts;

                    this.timeCost = (works[i].TotalServiceTimeHours * 1500);
                    this.timeCost += (works[i].RemainingServiceTimeMinutes > 30) ? 1500 : (1500 / 2);

                }
            }

            StateOfTheWorksheetRegistration.numberOfWorksheets += this.numberOfWorksheets;
            StateOfTheWorksheetRegistration.numberOfWork += this.numberOfWorks;
            StateOfTheWorksheetRegistration.materialCost += this.materialCost;
            StateOfTheWorksheetRegistration.serviceCost += this.timeCost;
            StateOfTheWorksheetRegistration.totalToPay += this.timeCost + this.materialCost;

        }







    }
}
