namespace Car_Repair
{
    partial class Munkalap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.anyagkoltsegLabel = new System.Windows.Forms.Label();
            this.munkaidoLabel = new System.Windows.Forms.Label();
            this.munkadijLabel = new System.Windows.Forms.Label();
            this.osszAnyagkoltsegLabel = new System.Windows.Forms.Label();
            this.totalMaterialCostTextBox = new System.Windows.Forms.TextBox();
            this.osszMunkadijLabel = new System.Windows.Forms.Label();
            this.totalWorPriceTextBox = new System.Windows.Forms.TextBox();
            this.rogzitesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 345);
            this.panel1.TabIndex = 0;
            // 
            // anyagkoltsegLabel
            // 
            this.anyagkoltsegLabel.AutoSize = true;
            this.anyagkoltsegLabel.Location = new System.Drawing.Point(258, 49);
            this.anyagkoltsegLabel.Name = "anyagkoltsegLabel";
            this.anyagkoltsegLabel.Size = new System.Drawing.Size(93, 17);
            this.anyagkoltsegLabel.TabIndex = 1;
            this.anyagkoltsegLabel.Text = "Anyagköltség";
            // 
            // munkaidoLabel
            // 
            this.munkaidoLabel.AutoSize = true;
            this.munkaidoLabel.Location = new System.Drawing.Point(379, 49);
            this.munkaidoLabel.Name = "munkaidoLabel";
            this.munkaidoLabel.Size = new System.Drawing.Size(69, 17);
            this.munkaidoLabel.TabIndex = 2;
            this.munkaidoLabel.Text = "Munkaidő";
            // 
            // munkadijLabel
            // 
            this.munkadijLabel.AutoSize = true;
            this.munkadijLabel.Location = new System.Drawing.Point(569, 49);
            this.munkadijLabel.Name = "munkadijLabel";
            this.munkadijLabel.Size = new System.Drawing.Size(64, 17);
            this.munkadijLabel.TabIndex = 3;
            this.munkadijLabel.Text = "Munkadíj";
            // 
            // osszAnyagkoltsegLabel
            // 
            this.osszAnyagkoltsegLabel.AutoSize = true;
            this.osszAnyagkoltsegLabel.Location = new System.Drawing.Point(27, 466);
            this.osszAnyagkoltsegLabel.Name = "osszAnyagkoltsegLabel";
            this.osszAnyagkoltsegLabel.Size = new System.Drawing.Size(97, 17);
            this.osszAnyagkoltsegLabel.TabIndex = 4;
            this.osszAnyagkoltsegLabel.Text = "Anyagköltség:";
            // 
            // totalMaterialCostTextBox
            // 
            this.totalMaterialCostTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalMaterialCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalMaterialCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMaterialCostTextBox.ForeColor = System.Drawing.Color.Green;
            this.totalMaterialCostTextBox.Location = new System.Drawing.Point(130, 463);
            this.totalMaterialCostTextBox.Name = "totalMaterialCostTextBox";
            this.totalMaterialCostTextBox.Size = new System.Drawing.Size(104, 27);
            this.totalMaterialCostTextBox.TabIndex = 5;
            // 
            // osszMunkadijLabel
            // 
            this.osszMunkadijLabel.AutoSize = true;
            this.osszMunkadijLabel.Location = new System.Drawing.Point(280, 466);
            this.osszMunkadijLabel.Name = "osszMunkadijLabel";
            this.osszMunkadijLabel.Size = new System.Drawing.Size(68, 17);
            this.osszMunkadijLabel.TabIndex = 6;
            this.osszMunkadijLabel.Text = "Munkadíj:";
            // 
            // totalWorPriceTextBox
            // 
            this.totalWorPriceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalWorPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalWorPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWorPriceTextBox.ForeColor = System.Drawing.Color.Red;
            this.totalWorPriceTextBox.Location = new System.Drawing.Point(354, 460);
            this.totalWorPriceTextBox.Name = "totalWorPriceTextBox";
            this.totalWorPriceTextBox.Size = new System.Drawing.Size(124, 27);
            this.totalWorPriceTextBox.TabIndex = 7;
            // 
            // rogzitesButton
            // 
            this.rogzitesButton.Location = new System.Drawing.Point(535, 449);
            this.rogzitesButton.Name = "rogzitesButton";
            this.rogzitesButton.Size = new System.Drawing.Size(141, 51);
            this.rogzitesButton.TabIndex = 8;
            this.rogzitesButton.Text = "Rögzítés";
            this.rogzitesButton.UseVisualStyleBackColor = true;
            this.rogzitesButton.Click += new System.EventHandler(this.rogzitesButton_Click);
            // 
            // Munkalap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 513);
            this.Controls.Add(this.rogzitesButton);
            this.Controls.Add(this.totalWorPriceTextBox);
            this.Controls.Add(this.osszMunkadijLabel);
            this.Controls.Add(this.totalMaterialCostTextBox);
            this.Controls.Add(this.osszAnyagkoltsegLabel);
            this.Controls.Add(this.munkadijLabel);
            this.Controls.Add(this.munkaidoLabel);
            this.Controls.Add(this.anyagkoltsegLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Munkalap";
            this.Text = "Munkalap készítés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Munkalap_FormClosing);
            this.Load += new System.EventHandler(this.Munkalap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label anyagkoltsegLabel;
        private System.Windows.Forms.Label munkaidoLabel;
        private System.Windows.Forms.Label munkadijLabel;
        private System.Windows.Forms.Label osszAnyagkoltsegLabel;
        private System.Windows.Forms.TextBox totalMaterialCostTextBox;
        private System.Windows.Forms.Label osszMunkadijLabel;
        private System.Windows.Forms.TextBox totalWorPriceTextBox;
        private System.Windows.Forms.Button rogzitesButton;
    }
}