using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Repair
{
    public partial class MainForm : Form
    {
        private List<Work> listOfWorks = new List<Work>();
        private List<RecordedWorksheet> listOfRecordedWorksheets = new List<RecordedWorksheet>();
        private Munkalap munkalap;
        
        
 

        public MainForm()
        {
            InitializeComponent();
        }





        private void betoltesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ReadFile())
            {
                munkalapToolStripMenuItem.Enabled = true;
                fizetesToolStripMenuItem.Enabled = false;
                listOfRecordedWorksheets.Clear();
            }
        }

        private bool ReadFile()
        {
            bool retVal = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    string file = openFileDialog.FileName;
                    this.listOfWorks = new Loader<Work>(new WorkParser()).ParseFile(file);
                    retVal = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        String.Format("Hiba történt a fájl olvasása közben! {0}", ex.Message),
                        "Figyeleme!"
                    );
                }
                
            }

            return retVal;
        }

        private void munkalapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            munkalap = new Munkalap(listOfWorks);
            munkalap.Rogzites += Munkalap_Rogzites;
            
            munkalap.Show();

            
        }

        private void Munkalap_Rogzites(object sender, EventArgs e)
        {
            
            fizetesToolStripMenuItem.Enabled = true;
            listOfRecordedWorksheets.Add(munkalap.WorksToRecord);
            
        }

        private void fizetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fizetes fizetes = new Fizetes(listOfRecordedWorksheets);
            fizetes.FizetesClosed += Fizetes_Closed;
            fizetes.Show();
        }

        public void Fizetes_Closed(object sender, EventArgs e)
        {
            fizetesToolStripMenuItem.Enabled = false;
            listOfRecordedWorksheets.Clear();
        }

        private void nevjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("yyyy.MM.dd");
            MessageBox.Show(today + "\n" +
                "Car_Repair", "Névjegy");
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = ConfirmExit() != DialogResult.Yes;
        }

        private DialogResult ConfirmExit()
        {
            return MessageBox.Show(
                    "Biztosan ki akar lépni?",
                    "Kilépés",
                    MessageBoxButtons.YesNo
                );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            munkalapToolStripMenuItem.Enabled = false;
            fizetesToolStripMenuItem.Enabled = false;
            
        }


        

 
    }
}
