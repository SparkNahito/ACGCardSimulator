namespace AcgPlaySimulator.Field
{
    partial class DeckForm
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
            DeckPanel = new Panel();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            DeckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // DeckPanel
            // 
            DeckPanel.BackColor = SystemColors.ActiveCaption;
            DeckPanel.BorderStyle = BorderStyle.Fixed3D;
            DeckPanel.Controls.Add(pictureBox6);
            DeckPanel.Controls.Add(label8);
            DeckPanel.Location = new Point(12, 12);
            DeckPanel.Name = "DeckPanel";
            DeckPanel.Size = new Size(1560, 179);
            DeckPanel.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(3, 18);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(105, 151);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(216, 15);
            label8.TabIndex = 0;
            label8.Text = "Shiftで公開。　Ctrlで非公開でフリーに移動";
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 200);
            Controls.Add(DeckPanel);
            Name = "DeckForm";
            Text = "DeckForm";
            Load += DeckForm_Load;
            DeckPanel.ResumeLayout(false);
            DeckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DeckPanel;
        private PictureBox pictureBox6;
        private Label label8;
    }
}