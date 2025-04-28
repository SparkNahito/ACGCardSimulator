namespace AcgPlaySimulator
{
    partial class DeckLoadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadButton = new Button();
            SuspendLayout();
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(233, 52);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(291, 64);
            LoadButton.TabIndex = 0;
            LoadButton.Text = "デッキ読み込み";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // DeckLoadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadButton);
            Name = "DeckLoadForm";
            Text = "DeckLoad";
            Load += DeckLoadForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button LoadButton;
    }
}
