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
    public partial class Fizetes : Form
    {
        private List<RecordedWorksheet> recordedWorksheets;

        private int worksheetNum = 0;
        private int workNum = 0;
        private int materilaCost = 0;
        private int workCost = 0;
        private int totalTime = 0;
        private int totalCost = 0;


        public Fizetes(List<RecordedWorksheet> recordedWorksheets)
        {
            InitializeComponent();
            this.recordedWorksheets = recordedWorksheets;
        }

        private void Fizetes_Load(object sender, EventArgs e)
        {
            CreateContent();
        }

        private void CreateContent()
        {
            worksheetNum = recordedWorksheets.Count;

            foreach (var item in recordedWorksheets)
            {
                workNum += item.NumberOfWorks;
                materilaCost += item.MatCostOfWorks;
                totalTime += item.SumTimeOfWorks;

            }

            workCost = (int) (7500 * (Math.Ceiling((decimal)totalTime / 30)));
            totalCost = materilaCost + workCost;

            recWorksheetNumTextBox.Text = worksheetNum.ToString() + " db";
            recWorkNumTextBox.Text = workNum.ToString() + " db";
            totalMatCostTextBox.Text = materilaCost.ToString() + " Ft";
            totalWorkCostTextBox.Text = workCost.ToString() + " Ft";
            totalWorkTimeTextBox.Text = (totalTime / 60).ToString() + " óra " + (totalTime % 60).ToString() + " perc";
            totalCostTextBox.Text = totalCost.ToString() + " Ft";
        }

        public event EventHandler FizetesClosed;

        private void Fizetes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FizetesClosed != null)
            {
                FizetesClosed(this, null);
            }
        }
    }
}
