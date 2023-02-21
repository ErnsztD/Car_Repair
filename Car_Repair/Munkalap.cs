using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Repair
{
    public partial class Munkalap : Form
    {
        private List<Work> listOfworks;

        private const int yDistance = 40;

        private List<CheckBox> CheckBoxes = new List<CheckBox>();
        private List<Label> WorkPriceLabels = new List<Label>();

        private int totalCheckedTime = 0;
        private int totalCheckedMaterial = 0;
        private int checkedWorkCount = 0;

        private bool isrecorded = false;

        public RecordedWorksheet WorksToRecord = new RecordedWorksheet(0, 0, 0);

        public Munkalap(List<Work> worklist)
        {
            InitializeComponent();
            this.listOfworks = worklist;
        }



        private void Munkalap_Load(object sender, EventArgs e)
        {
            CreateDynamicContent();
        }

        private void CreateDynamicContent()
        {
            for (int i = 0; i < listOfworks.Count; i++)
            {
                CreateControlsOfItem(listOfworks[i], i);
            }
        }

        private void CreateControlsOfItem(Work item, int index)
        {
            Label workNameLabel;
            Label matPriceLabel;
            Label workTimeLabel;
            CheckBox workCheckBox;
            Label workPriceLabel;
            // 
            // workNameLabel
            // 
            workNameLabel = new Label();
            workNameLabel.AutoSize = true;
            workNameLabel.Location = new System.Drawing.Point(15, 12 + index * yDistance);
            workNameLabel.Size = new System.Drawing.Size(85, 17);
            workNameLabel.Text = item.WorkName;
            // 
            // matPriceLabel
            // 
            matPriceLabel = new Label();
            matPriceLabel.AutoSize = true;
            matPriceLabel.Location = new System.Drawing.Point(200, 12 + index * yDistance);
            matPriceLabel.Size = new System.Drawing.Size(56, 17);
            matPriceLabel.Text = item.MaterialCost.ToString() + " Ft";
            // 
            // workTimeLabel
            // 
            workTimeLabel = new Label();
            workTimeLabel.AutoSize = true;
            workTimeLabel.Location = new System.Drawing.Point(280, 12 + index * yDistance);
            workTimeLabel.Size = new System.Drawing.Size(56, 17);
            workTimeLabel.Text = item.WorkTimeHour.ToString() + "ó " + item.WorkTimeMin.ToString() + "p";
            // 
            // workCheckBox
            // 
            workCheckBox = new CheckBox();
            workCheckBox.AutoSize = true;
            workCheckBox.Location = new System.Drawing.Point(360, 12 + index * yDistance);
            workCheckBox.Size = new System.Drawing.Size(18, 18);
            workCheckBox.UseVisualStyleBackColor = true;
            workCheckBox.CheckedChanged += new EventHandler(CheckBox_Checked);
            CheckBoxes.Add(workCheckBox);
            // 
            // workPriceLabel
            // 
            workPriceLabel = new Label();
            workPriceLabel.AutoSize = true;
            workPriceLabel.Location = new System.Drawing.Point(420, 12 + index * yDistance);
            workPriceLabel.Size = new System.Drawing.Size(64, 17);
            workPriceLabel.Text = item.WorkPrice.ToString() + " Ft";
            workPriceLabel.Visible = false;
            WorkPriceLabels.Add(workPriceLabel);

            panel1.Controls.Add(workNameLabel);
            panel1.Controls.Add(matPriceLabel);
            panel1.Controls.Add(workTimeLabel);
            panel1.Controls.Add(workCheckBox);
            panel1.Controls.Add(workPriceLabel);
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);

            if (cb.Checked)
            {
                checkedWorkCount += 1;
                totalCheckedMaterial += listOfworks[CheckBoxes.IndexOf(cb)].MaterialCost;
                totalCheckedTime += listOfworks[CheckBoxes.IndexOf(cb)].WorkTime;
                totalMaterialCostTextBox.Text = totalCheckedMaterial.ToString() + " Ft";
                totalWorPriceTextBox.Text = (7500 * (Math.Ceiling((decimal)totalCheckedTime / 30))).ToString() + " Ft";
                WorkPriceLabels[CheckBoxes.IndexOf(cb)].Visible = true;
                WorksToRecord.NumberOfWorks += 1;
                WorksToRecord.MatCostOfWorks += listOfworks[CheckBoxes.IndexOf(cb)].MaterialCost;
                WorksToRecord.SumTimeOfWorks += listOfworks[CheckBoxes.IndexOf(cb)].WorkTime;

            }

            if (!cb.Checked)
            {
                checkedWorkCount -= 1;
                totalCheckedMaterial -= listOfworks[CheckBoxes.IndexOf(cb)].MaterialCost;
                totalCheckedTime -= listOfworks[CheckBoxes.IndexOf(cb)].WorkTime;
                totalMaterialCostTextBox.Text = totalCheckedMaterial.ToString() + " Ft";
                totalWorPriceTextBox.Text = (7500 * (Math.Ceiling((decimal)totalCheckedTime / 30))).ToString() + " Ft";
                WorkPriceLabels[CheckBoxes.IndexOf(cb)].Visible = false;
                WorksToRecord.NumberOfWorks -= 1;
                WorksToRecord.MatCostOfWorks -= listOfworks[CheckBoxes.IndexOf(cb)].MaterialCost;
                WorksToRecord.SumTimeOfWorks -= listOfworks[CheckBoxes.IndexOf(cb)].WorkTime;
            }
        }

        private void Munkalap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isrecorded)
            {
                e.Cancel = ConfirmExit() != DialogResult.Yes;
            }

        }

        private DialogResult ConfirmExit()
        {
            return MessageBox.Show(
                    "Biztosan ki akar lépni?\n" +
                    "Rögzítés nélkül az adatok elvesznek!",
                    "Kilépés",
                    MessageBoxButtons.YesNo
                );
        }

        public event EventHandler Rogzites;

        private void rogzitesButton_Click(object sender, EventArgs e)
        {


            string answere = ConfirmRogzit().ToString();
            if (answere == "Yes")
            {
                isrecorded = true;
                if (Rogzites != null)
                {
                    Rogzites(this, null);
                }

                Close();
            }
            


            
        }

        private DialogResult ConfirmRogzit()
        {
            return MessageBox.Show(
                    "Rögzíti a munkalapot?",
                    "Rögzítés",
                    MessageBoxButtons.YesNo
                );
        }

    }

    

    
}


