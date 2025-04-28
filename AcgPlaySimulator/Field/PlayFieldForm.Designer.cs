namespace AcgPlaySimulator.Field
{
    partial class PlayFieldForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayFieldForm));
            handPanel = new Panel();
            pictureBox = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            MainSearchButton = new Button();
            MainNnmberLabel = new Label();
            MainShuffleButton = new Button();
            MainCheckButton = new Button();
            MainOpenButton = new Button();
            MainDrawButton = new Button();
            label2 = new Label();
            mainDeckPictureBox = new PictureBox();
            panel2 = new Panel();
            LandNumberLabel = new Label();
            LandShuffleButton = new Button();
            LandCheckButton = new Button();
            LandOpenButton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            LandPanel = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            freePanel = new Panel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            FieldPanel = new Panel();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            ImageContextMenuStrip = new ContextMenuStrip(components);
            戦場に移動するToolStripMenuItem = new ToolStripMenuItem();
            墓地に移動するToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            フリースペースに移動するToolStripMenuItem = new ToolStripMenuItem();
            カウンター追加ToolStripMenuItem = new ToolStripMenuItem();
            個ToolStripMenuItem = new ToolStripMenuItem();
            個ToolStripMenuItem1 = new ToolStripMenuItem();
            個ToolStripMenuItem2 = new ToolStripMenuItem();
            個ToolStripMenuItem3 = new ToolStripMenuItem();
            個ToolStripMenuItem4 = new ToolStripMenuItem();
            個ToolStripMenuItem5 = new ToolStripMenuItem();
            裏にするToolStripMenuItem = new ToolStripMenuItem();
            メインデッキに戻すToolStripMenuItem = new ToolStripMenuItem();
            MainTopMoveToolStripMenuItem = new ToolStripMenuItem();
            MainBottomMoveToolStripMenuItem = new ToolStripMenuItem();
            領土デッキに戻すToolStripMenuItem = new ToolStripMenuItem();
            LandTopMoveToolStripMenuItem = new ToolStripMenuItem();
            LandBottomMoveToolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            CemeteryPanel = new Panel();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            RemovePanel = new Panel();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            DeliveryButton = new Button();
            SideButton = new Button();
            button6 = new Button();
            numericUpDown1 = new NumericUpDown();
            handPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDeckPictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            freePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            FieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ImageContextMenuStrip.SuspendLayout();
            CemeteryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            RemovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // handPanel
            // 
            handPanel.BackColor = SystemColors.ActiveCaption;
            handPanel.BorderStyle = BorderStyle.Fixed3D;
            handPanel.Controls.Add(pictureBox);
            handPanel.Controls.Add(label1);
            handPanel.Location = new Point(17, 431);
            handPanel.Name = "handPanel";
            handPanel.Size = new Size(749, 176);
            handPanel.TabIndex = 0;
            handPanel.Click += handPanel_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 18);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(105, 151);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "手札";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(MainSearchButton);
            panel1.Controls.Add(MainNnmberLabel);
            panel1.Controls.Add(MainShuffleButton);
            panel1.Controls.Add(MainCheckButton);
            panel1.Controls.Add(MainOpenButton);
            panel1.Controls.Add(MainDrawButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(mainDeckPictureBox);
            panel1.Location = new Point(772, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 176);
            panel1.TabIndex = 1;
            // 
            // MainSearchButton
            // 
            MainSearchButton.Location = new Point(3, 134);
            MainSearchButton.Name = "MainSearchButton";
            MainSearchButton.Size = new Size(61, 23);
            MainSearchButton.TabIndex = 9;
            MainSearchButton.Text = "探す";
            MainSearchButton.UseVisualStyleBackColor = true;
            MainSearchButton.Click += MainSearchButton_Click;
            // 
            // MainNnmberLabel
            // 
            MainNnmberLabel.AutoSize = true;
            MainNnmberLabel.Location = new Point(99, 132);
            MainNnmberLabel.Name = "MainNnmberLabel";
            MainNnmberLabel.Size = new Size(31, 15);
            MainNnmberLabel.TabIndex = 8;
            MainNnmberLabel.Text = "40枚";
            // 
            // MainShuffleButton
            // 
            MainShuffleButton.Location = new Point(3, 105);
            MainShuffleButton.Name = "MainShuffleButton";
            MainShuffleButton.Size = new Size(61, 23);
            MainShuffleButton.TabIndex = 7;
            MainShuffleButton.Text = "シャッフル";
            MainShuffleButton.UseVisualStyleBackColor = true;
            MainShuffleButton.Click += MainShuffleButton_Click;
            // 
            // MainCheckButton
            // 
            MainCheckButton.Location = new Point(3, 76);
            MainCheckButton.Name = "MainCheckButton";
            MainCheckButton.Size = new Size(61, 23);
            MainCheckButton.TabIndex = 6;
            MainCheckButton.Text = "1枚確認";
            MainCheckButton.UseVisualStyleBackColor = true;
            MainCheckButton.Click += MainCheckButton_Click;
            // 
            // MainOpenButton
            // 
            MainOpenButton.Location = new Point(3, 47);
            MainOpenButton.Name = "MainOpenButton";
            MainOpenButton.Size = new Size(61, 23);
            MainOpenButton.TabIndex = 5;
            MainOpenButton.Text = "1枚公開";
            MainOpenButton.UseVisualStyleBackColor = true;
            MainOpenButton.Click += MainOpenButton_Click;
            // 
            // MainDrawButton
            // 
            MainDrawButton.Location = new Point(3, 18);
            MainDrawButton.Name = "MainDrawButton";
            MainDrawButton.Size = new Size(61, 23);
            MainDrawButton.TabIndex = 4;
            MainDrawButton.Text = "1枚引く";
            MainDrawButton.UseVisualStyleBackColor = true;
            MainDrawButton.Click += MainDrawButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "メインデッキ";
            // 
            // mainDeckPictureBox
            // 
            mainDeckPictureBox.Image = (Image)resources.GetObject("mainDeckPictureBox.Image");
            mainDeckPictureBox.Location = new Point(67, 9);
            mainDeckPictureBox.Name = "mainDeckPictureBox";
            mainDeckPictureBox.Size = new Size(105, 151);
            mainDeckPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mainDeckPictureBox.TabIndex = 2;
            mainDeckPictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(LandNumberLabel);
            panel2.Controls.Add(LandShuffleButton);
            panel2.Controls.Add(LandCheckButton);
            panel2.Controls.Add(LandOpenButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(772, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 176);
            panel2.TabIndex = 2;
            // 
            // LandNumberLabel
            // 
            LandNumberLabel.AutoSize = true;
            LandNumberLabel.Location = new Point(99, 132);
            LandNumberLabel.Name = "LandNumberLabel";
            LandNumberLabel.Size = new Size(31, 15);
            LandNumberLabel.TabIndex = 8;
            LandNumberLabel.Text = "40枚";
            // 
            // LandShuffleButton
            // 
            LandShuffleButton.Location = new Point(3, 105);
            LandShuffleButton.Name = "LandShuffleButton";
            LandShuffleButton.Size = new Size(61, 23);
            LandShuffleButton.TabIndex = 7;
            LandShuffleButton.Text = "シャッフル";
            LandShuffleButton.UseVisualStyleBackColor = true;
            LandShuffleButton.Click += LandShuffleButton_Click;
            // 
            // LandCheckButton
            // 
            LandCheckButton.Location = new Point(3, 47);
            LandCheckButton.Name = "LandCheckButton";
            LandCheckButton.Size = new Size(61, 23);
            LandCheckButton.TabIndex = 6;
            LandCheckButton.Text = "1枚確認";
            LandCheckButton.UseVisualStyleBackColor = true;
            LandCheckButton.Click += LandCheckButton_Click;
            // 
            // LandOpenButton
            // 
            LandOpenButton.Location = new Point(3, 18);
            LandOpenButton.Name = "LandOpenButton";
            LandOpenButton.Size = new Size(61, 23);
            LandOpenButton.TabIndex = 5;
            LandOpenButton.Text = "1枚追加";
            LandOpenButton.UseVisualStyleBackColor = true;
            LandOpenButton.Click += LandOpenButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "領土デッキ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LandPanel
            // 
            LandPanel.BackColor = SystemColors.ActiveCaption;
            LandPanel.BorderStyle = BorderStyle.Fixed3D;
            LandPanel.Controls.Add(pictureBox2);
            LandPanel.Controls.Add(label3);
            LandPanel.Location = new Point(17, 254);
            LandPanel.Name = "LandPanel";
            LandPanel.Size = new Size(749, 176);
            LandPanel.TabIndex = 3;
            LandPanel.Click += LandPanel_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "領土";
            // 
            // freePanel
            // 
            freePanel.BackColor = SystemColors.ActiveCaption;
            freePanel.BorderStyle = BorderStyle.Fixed3D;
            freePanel.Controls.Add(pictureBox4);
            freePanel.Controls.Add(label6);
            freePanel.Location = new Point(957, 254);
            freePanel.Name = "freePanel";
            freePanel.Size = new Size(353, 176);
            freePanel.TabIndex = 4;
            freePanel.Click += freePanel_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(3, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(105, 151);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "フリースペース";
            // 
            // FieldPanel
            // 
            FieldPanel.BackColor = SystemColors.ActiveCaption;
            FieldPanel.BorderStyle = BorderStyle.Fixed3D;
            FieldPanel.Controls.Add(pictureBox5);
            FieldPanel.Controls.Add(label7);
            FieldPanel.Location = new Point(17, 77);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(749, 176);
            FieldPanel.TabIndex = 4;
            FieldPanel.Click += FieldPanel_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(3, 18);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(105, 151);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 0;
            label7.Text = "戦場";
            // 
            // ImageContextMenuStrip
            // 
            ImageContextMenuStrip.Items.AddRange(new ToolStripItem[] { 戦場に移動するToolStripMenuItem, 墓地に移動するToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, フリースペースに移動するToolStripMenuItem, カウンター追加ToolStripMenuItem, 裏にするToolStripMenuItem, メインデッキに戻すToolStripMenuItem, 領土デッキに戻すToolStripMenuItem, toolStripMenuItem3 });
            ImageContextMenuStrip.Name = "contextMenuStrip1";
            ImageContextMenuStrip.Size = new Size(187, 224);
            ImageContextMenuStrip.Opening += ImageContextMenuStrip_Opening;
            // 
            // 戦場に移動するToolStripMenuItem
            // 
            戦場に移動するToolStripMenuItem.Name = "戦場に移動するToolStripMenuItem";
            戦場に移動するToolStripMenuItem.Size = new Size(186, 22);
            戦場に移動するToolStripMenuItem.Text = "戦場に移動する";
            戦場に移動するToolStripMenuItem.Click += 戦場に移動するToolStripMenuItem_Click;
            // 
            // 墓地に移動するToolStripMenuItem
            // 
            墓地に移動するToolStripMenuItem.Name = "墓地に移動するToolStripMenuItem";
            墓地に移動するToolStripMenuItem.Size = new Size(186, 22);
            墓地に移動するToolStripMenuItem.Text = "墓地に移動する";
            墓地に移動するToolStripMenuItem.Click += 墓地に移動するToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(186, 22);
            toolStripMenuItem2.Text = "除外に移動する";
            toolStripMenuItem2.Click += 除外に移動するToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(186, 22);
            toolStripMenuItem1.Text = "手札に移動する";
            toolStripMenuItem1.Click += 手札に移動するToolStripMenuItem_Click;
            // 
            // フリースペースに移動するToolStripMenuItem
            // 
            フリースペースに移動するToolStripMenuItem.Name = "フリースペースに移動するToolStripMenuItem";
            フリースペースに移動するToolStripMenuItem.Size = new Size(186, 22);
            フリースペースに移動するToolStripMenuItem.Text = "フリースペースに移動する";
            // 
            // カウンター追加ToolStripMenuItem
            // 
            カウンター追加ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 個ToolStripMenuItem, 個ToolStripMenuItem1, 個ToolStripMenuItem2, 個ToolStripMenuItem3, 個ToolStripMenuItem4, 個ToolStripMenuItem5 });
            カウンター追加ToolStripMenuItem.Name = "カウンター追加ToolStripMenuItem";
            カウンター追加ToolStripMenuItem.Size = new Size(186, 22);
            カウンター追加ToolStripMenuItem.Text = "カウンター追加";
            // 
            // 個ToolStripMenuItem
            // 
            個ToolStripMenuItem.Name = "個ToolStripMenuItem";
            個ToolStripMenuItem.Size = new Size(98, 22);
            個ToolStripMenuItem.Text = "１個";
            個ToolStripMenuItem.Click += 個ToolStripMenuItem_Click;
            // 
            // 個ToolStripMenuItem1
            // 
            個ToolStripMenuItem1.Name = "個ToolStripMenuItem1";
            個ToolStripMenuItem1.Size = new Size(98, 22);
            個ToolStripMenuItem1.Text = "２個";
            個ToolStripMenuItem1.Click += 個ToolStripMenuItem1_Click;
            // 
            // 個ToolStripMenuItem2
            // 
            個ToolStripMenuItem2.Name = "個ToolStripMenuItem2";
            個ToolStripMenuItem2.Size = new Size(98, 22);
            個ToolStripMenuItem2.Text = "３個";
            個ToolStripMenuItem2.Click += 個ToolStripMenuItem2_Click;
            // 
            // 個ToolStripMenuItem3
            // 
            個ToolStripMenuItem3.Name = "個ToolStripMenuItem3";
            個ToolStripMenuItem3.Size = new Size(98, 22);
            個ToolStripMenuItem3.Text = "４個";
            個ToolStripMenuItem3.Click += 個ToolStripMenuItem3_Click;
            // 
            // 個ToolStripMenuItem4
            // 
            個ToolStripMenuItem4.Name = "個ToolStripMenuItem4";
            個ToolStripMenuItem4.Size = new Size(98, 22);
            個ToolStripMenuItem4.Text = "５個";
            個ToolStripMenuItem4.Click += five個ToolStripMenuItem4_Click;
            // 
            // 個ToolStripMenuItem5
            // 
            個ToolStripMenuItem5.Name = "個ToolStripMenuItem5";
            個ToolStripMenuItem5.Size = new Size(98, 22);
            個ToolStripMenuItem5.Text = "６個";
            個ToolStripMenuItem5.Click += 個ToolStripMenuItem5_Click;
            // 
            // 裏にするToolStripMenuItem
            // 
            裏にするToolStripMenuItem.Name = "裏にするToolStripMenuItem";
            裏にするToolStripMenuItem.Size = new Size(186, 22);
            裏にするToolStripMenuItem.Text = "裏返す";
            裏にするToolStripMenuItem.Click += 裏にするToolStripMenuItem_Click;
            // 
            // メインデッキに戻すToolStripMenuItem
            // 
            メインデッキに戻すToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MainTopMoveToolStripMenuItem, MainBottomMoveToolStripMenuItem });
            メインデッキに戻すToolStripMenuItem.Name = "メインデッキに戻すToolStripMenuItem";
            メインデッキに戻すToolStripMenuItem.Size = new Size(186, 22);
            メインデッキに戻すToolStripMenuItem.Text = "メインデッキに戻す";
            // 
            // MainTopMoveToolStripMenuItem
            // 
            MainTopMoveToolStripMenuItem.Name = "MainTopMoveToolStripMenuItem";
            MainTopMoveToolStripMenuItem.Size = new Size(153, 22);
            MainTopMoveToolStripMenuItem.Text = "デッキの上に戻す";
            MainTopMoveToolStripMenuItem.Click += MainTopMoveToolStripMenuItem_Click;
            // 
            // MainBottomMoveToolStripMenuItem
            // 
            MainBottomMoveToolStripMenuItem.Name = "MainBottomMoveToolStripMenuItem";
            MainBottomMoveToolStripMenuItem.Size = new Size(153, 22);
            MainBottomMoveToolStripMenuItem.Text = "デッキの下に戻す";
            MainBottomMoveToolStripMenuItem.Click += MainBottomMoveToolStripMenuItem_Click;
            // 
            // 領土デッキに戻すToolStripMenuItem
            // 
            領土デッキに戻すToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LandTopMoveToolStripMenuItem, LandBottomMoveToolStripMenuItem4 });
            領土デッキに戻すToolStripMenuItem.Name = "領土デッキに戻すToolStripMenuItem";
            領土デッキに戻すToolStripMenuItem.Size = new Size(186, 22);
            領土デッキに戻すToolStripMenuItem.Text = "領土デッキに戻す";
            // 
            // LandTopMoveToolStripMenuItem
            // 
            LandTopMoveToolStripMenuItem.Name = "LandTopMoveToolStripMenuItem";
            LandTopMoveToolStripMenuItem.Size = new Size(153, 22);
            LandTopMoveToolStripMenuItem.Text = "デッキの上に戻す";
            LandTopMoveToolStripMenuItem.Click += LandTopMoveToolStripMenuItem_Click;
            // 
            // LandBottomMoveToolStripMenuItem4
            // 
            LandBottomMoveToolStripMenuItem4.Name = "LandBottomMoveToolStripMenuItem4";
            LandBottomMoveToolStripMenuItem4.Size = new Size(153, 22);
            LandBottomMoveToolStripMenuItem4.Text = "デッキの下に戻す";
            LandBottomMoveToolStripMenuItem4.Click += LandBottomMoveToolStripMenuItem4_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(186, 22);
            toolStripMenuItem3.Text = "詳細確認";
            toolStripMenuItem3.Click += 詳細確認toolStripMenuItem_Click;
            // 
            // CemeteryPanel
            // 
            CemeteryPanel.BackColor = SystemColors.ActiveCaption;
            CemeteryPanel.BorderStyle = BorderStyle.Fixed3D;
            CemeteryPanel.Controls.Add(pictureBox6);
            CemeteryPanel.Controls.Add(label8);
            CemeteryPanel.Location = new Point(17, 608);
            CemeteryPanel.Name = "CemeteryPanel";
            CemeteryPanel.Size = new Size(1293, 179);
            CemeteryPanel.TabIndex = 5;
            CemeteryPanel.Click += CemeteryPanel_Click;
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
            label8.Size = new Size(31, 15);
            label8.TabIndex = 0;
            label8.Text = "墓地";
            // 
            // RemovePanel
            // 
            RemovePanel.BackColor = SystemColors.ActiveCaption;
            RemovePanel.BorderStyle = BorderStyle.Fixed3D;
            RemovePanel.Controls.Add(pictureBox7);
            RemovePanel.Controls.Add(label9);
            RemovePanel.Location = new Point(772, 431);
            RemovePanel.Name = "RemovePanel";
            RemovePanel.Size = new Size(538, 176);
            RemovePanel.TabIndex = 6;
            RemovePanel.Click += RemovePanel_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(3, 18);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(105, 151);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 0;
            label9.Text = "除外";
            // 
            // button1
            // 
            button1.Location = new Point(17, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 59);
            button1.TabIndex = 7;
            button1.Text = "起床";
            button1.UseVisualStyleBackColor = true;
            button1.Click += 起床button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 12);
            button2.Name = "button2";
            button2.Size = new Size(110, 59);
            button2.TabIndex = 8;
            button2.Text = "トークン作る";
            button2.UseVisualStyleBackColor = true;
            button2.Click += TokenButton_Click;
            // 
            // DeliveryButton
            // 
            DeliveryButton.Location = new Point(1200, 11);
            DeliveryButton.Name = "DeliveryButton";
            DeliveryButton.Size = new Size(110, 59);
            DeliveryButton.TabIndex = 9;
            DeliveryButton.Text = "配信用画面起動";
            DeliveryButton.UseVisualStyleBackColor = true;
            DeliveryButton.Click += DeliveryButton_Click;
            // 
            // SideButton
            // 
            SideButton.Location = new Point(1200, 79);
            SideButton.Name = "SideButton";
            SideButton.Size = new Size(110, 59);
            SideButton.TabIndex = 10;
            SideButton.Text = "サイドボーディング";
            SideButton.UseVisualStyleBackColor = true;
            SideButton.Click += SideButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(597, 12);
            button6.Name = "button6";
            button6.Size = new Size(110, 59);
            button6.TabIndex = 12;
            button6.Text = "墓地ソート";
            button6.UseVisualStyleBackColor = true;
            button6.Click += 墓地ソートbutton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numericUpDown1.Location = new Point(770, 20);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 50);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // PlayFieldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 794);
            Controls.Add(numericUpDown1);
            Controls.Add(button6);
            Controls.Add(SideButton);
            Controls.Add(DeliveryButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RemovePanel);
            Controls.Add(CemeteryPanel);
            Controls.Add(FieldPanel);
            Controls.Add(freePanel);
            Controls.Add(LandPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(handPanel);
            Name = "PlayFieldForm";
            Text = "PlayFieldForm";
            Load += PlayFieldForm_Load;
            handPanel.ResumeLayout(false);
            handPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainDeckPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LandPanel.ResumeLayout(false);
            LandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            freePanel.ResumeLayout(false);
            freePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            FieldPanel.ResumeLayout(false);
            FieldPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ImageContextMenuStrip.ResumeLayout(false);
            CemeteryPanel.ResumeLayout(false);
            CemeteryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            RemovePanel.ResumeLayout(false);
            RemovePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel handPanel;
        private PictureBox pictureBox;
        private Label label1;
        private Panel panel1;
        private PictureBox mainDeckPictureBox;
        private Label label2;
        private Button MainShuffleButton;
        private Button MainCheckButton;
        private Button MainOpenButton;
        private Button MainDrawButton;
        private Label MainNnmberLabel;
        private Panel panel2;
        private Label LandNumberLabel;
        private Button LandShuffleButton;
        private Button LandCheckButton;
        private Button LandOpenButton;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label5;
        private Panel LandPanel;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel freePanel;
        private PictureBox pictureBox4;
        private Label label6;
        private Panel FieldPanel;
        private PictureBox pictureBox5;
        private Label label7;
        private ContextMenuStrip ImageContextMenuStrip;
        private ToolStripMenuItem 戦場に移動するToolStripMenuItem;
        private ToolStripMenuItem 墓地に移動するToolStripMenuItem;
        private ToolStripMenuItem フリースペースに移動するToolStripMenuItem;
        private ToolStripMenuItem カウンター追加ToolStripMenuItem;
        private ToolStripMenuItem 個ToolStripMenuItem;
        private ToolStripMenuItem 個ToolStripMenuItem1;
        private ToolStripMenuItem 個ToolStripMenuItem2;
        private ToolStripMenuItem 個ToolStripMenuItem3;
        private ToolStripMenuItem 個ToolStripMenuItem4;
        private ToolStripMenuItem 個ToolStripMenuItem5;
        private ToolStripMenuItem 裏にするToolStripMenuItem;
        private ToolStripMenuItem メインデッキに戻すToolStripMenuItem;
        private ToolStripMenuItem 領土デッキに戻すToolStripMenuItem;
        private ToolStripMenuItem MainTopMoveToolStripMenuItem;
        private ToolStripMenuItem MainBottomMoveToolStripMenuItem;
        private ToolStripMenuItem LandTopMoveToolStripMenuItem;
        private ToolStripMenuItem LandBottomMoveToolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel CemeteryPanel;
        private PictureBox pictureBox6;
        private Label label8;
        private Panel RemovePanel;
        private PictureBox pictureBox7;
        private Label label9;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button button1;
        private Button button2;
        private Button DeliveryButton;
        private Button SideButton;
        private Button button5;
        private Button button6;
        private Button MainSearchButton;
        private NumericUpDown numericUpDown1;
    }
}