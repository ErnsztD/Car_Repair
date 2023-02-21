namespace Car_Repair
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.betoltesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.munkalapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betoltesToolStripMenuItem1,
            this.munkalapToolStripMenuItem,
            this.fizetesToolStripMenuItem,
            this.nevjegyToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // betoltesToolStripMenuItem1
            // 
            this.betoltesToolStripMenuItem1.Name = "betoltesToolStripMenuItem1";
            this.betoltesToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.betoltesToolStripMenuItem1.Text = "Fájl betöltés...";
            this.betoltesToolStripMenuItem1.Click += new System.EventHandler(this.betoltesToolStripMenuItem1_Click);
            // 
            // munkalapToolStripMenuItem
            // 
            this.munkalapToolStripMenuItem.Name = "munkalapToolStripMenuItem";
            this.munkalapToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.munkalapToolStripMenuItem.Text = "Munkalap...";
            this.munkalapToolStripMenuItem.Click += new System.EventHandler(this.munkalapToolStripMenuItem_Click);
            // 
            // fizetesToolStripMenuItem
            // 
            this.fizetesToolStripMenuItem.Name = "fizetesToolStripMenuItem";
            this.fizetesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.fizetesToolStripMenuItem.Text = "Fizetés...";
            this.fizetesToolStripMenuItem.Click += new System.EventHandler(this.fizetesToolStripMenuItem_Click);
            // 
            // nevjegyToolStripMenuItem
            // 
            this.nevjegyToolStripMenuItem.Name = "nevjegyToolStripMenuItem";
            this.nevjegyToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.nevjegyToolStripMenuItem.Text = "Névjegy...";
            this.nevjegyToolStripMenuItem.Click += new System.EventHandler(this.nevjegyToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Repair.Properties.Resources.car_repair_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Szerviz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem betoltesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem munkalapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ToolStripMenuItem fizetesToolStripMenuItem;
    }
}

