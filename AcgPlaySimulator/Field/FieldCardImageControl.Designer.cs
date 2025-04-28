namespace AcgPlaySimulator.Field
{
    partial class FieldCardImageControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            MinusButton = new Button();
            PlusButton = new Button();
            textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(151, 105);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(8, 8);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(30, 25);
            MinusButton.TabIndex = 1;
            MinusButton.Text = "－";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(71, 8);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(30, 25);
            PlusButton.TabIndex = 2;
            PlusButton.Text = "＋";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(35, 9);
            textBox.Name = "textBox";
            textBox.Size = new Size(39, 23);
            textBox.TabIndex = 3;
            // 
            // FieldCardImageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox);
            Controls.Add(PlusButton);
            Controls.Add(MinusButton);
            Controls.Add(pictureBox);
            Name = "FieldCardImageControl";
            Size = new Size(151, 105);
            Load += FieldCardImageControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button MinusButton;
        private Button PlusButton;
        private TextBox textBox;
    }
}
