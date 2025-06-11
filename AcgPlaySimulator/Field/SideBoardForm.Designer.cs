namespace AcgPlaySimulator.Field
{
    partial class SideBoardForm
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
            MainDeckPanel = new Panel();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            LandDeckPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SideDeckPanel = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            MainDeckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            LandDeckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SideDeckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MainDeckPanel
            // 
            MainDeckPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainDeckPanel.BackColor = SystemColors.ActiveCaption;
            MainDeckPanel.BorderStyle = BorderStyle.Fixed3D;
            MainDeckPanel.Controls.Add(pictureBox6);
            MainDeckPanel.Controls.Add(label8);
            MainDeckPanel.Location = new Point(12, 12);
            MainDeckPanel.Name = "MainDeckPanel";
            MainDeckPanel.Size = new Size(1560, 179);
            MainDeckPanel.TabIndex = 7;
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
            // LandDeckPanel
            // 
            LandDeckPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LandDeckPanel.BackColor = SystemColors.ActiveCaption;
            LandDeckPanel.BorderStyle = BorderStyle.Fixed3D;
            LandDeckPanel.Controls.Add(pictureBox1);
            LandDeckPanel.Controls.Add(label1);
            LandDeckPanel.Location = new Point(12, 197);
            LandDeckPanel.Name = "LandDeckPanel";
            LandDeckPanel.Size = new Size(1560, 179);
            LandDeckPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 0;
            label1.Text = "Shiftで公開。　Ctrlで非公開でフリーに移動";
            // 
            // SideDeckPanel
            // 
            SideDeckPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SideDeckPanel.BackColor = SystemColors.ActiveCaption;
            SideDeckPanel.BorderStyle = BorderStyle.Fixed3D;
            SideDeckPanel.Controls.Add(pictureBox2);
            SideDeckPanel.Controls.Add(label2);
            SideDeckPanel.Location = new Point(12, 382);
            SideDeckPanel.Name = "SideDeckPanel";
            SideDeckPanel.Size = new Size(1560, 179);
            SideDeckPanel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 15);
            label2.TabIndex = 0;
            label2.Text = "Shiftで公開。　Ctrlで非公開でフリーに移動";
            // 
            // SideBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 577);
            Controls.Add(SideDeckPanel);
            Controls.Add(LandDeckPanel);
            Controls.Add(MainDeckPanel);
            MaximizeBox = false;
            Name = "SideBoardForm";
            Text = "SideBoardForm";
            Load += SideBoardForm_Load;
            MainDeckPanel.ResumeLayout(false);
            MainDeckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            LandDeckPanel.ResumeLayout(false);
            LandDeckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SideDeckPanel.ResumeLayout(false);
            SideDeckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainDeckPanel;
        private PictureBox pictureBox6;
        private Label label8;
        private Panel LandDeckPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel SideDeckPanel;
        private PictureBox pictureBox2;
        private Label label2;
    }
}