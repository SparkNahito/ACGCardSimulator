using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcgPlaySimulator.Field
{
    public partial class FieldCardImageControl : UserControl
    {
        public PlayingCard? PlayingCard { get; set; }
        public Image? ReversedImage { get; set; }

        public MouseEventHandler MouseClick { get; set; }
        public EventHandler MouseDoubleClick { get; set; }
        public ContextMenuStrip? ContextMenuStrip { get; set; }

        public bool IsDelivery { get; set; }

        public FieldCardImageControl()
        {
            InitializeComponent();

            this.Disposed += FieldCardImageControl_Disposed;
        }

        private void FieldCardImageControl_Disposed(object? sender, EventArgs e)
        {
            pictureBox.Dispose();
        }

        private void FieldCardImageControl_Load(object sender, EventArgs e)
        {
            if (PlayingCard == null)
            {
                return;
            }

            this.Size = PlayingCard.IsMoved ? new Size(151, 105) : new Size(105, 151);
            pictureBox.Size = PlayingCard.IsMoved ? new Size(151, 105) : new Size(105, 151);
            var originalImage = PlayingCard.CardInfo.Image;
            if (PlayingCard.IsReversed
                || IsDelivery && !PlayingCard.IsOpen)
            {
                originalImage = ReversedImage;
            }
            if (PlayingCard.IsMoved)
            {
                var flipImage = originalImage?.Clone() as Image;
                flipImage?.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox.Image = flipImage;
            }
            else
            {
                pictureBox.Image = originalImage;
            }
            if (0 < PlayingCard.Counters.Count)
            {
                PlusButton.Visible = true;
                MinusButton.Visible = true;
                textBox.Visible = true;
                textBox.Text = PlayingCard.Counters[0].Value.ToString();
                textBox.ReadOnly = true;
            }
            else
            {
                PlusButton.Visible = false;
                MinusButton.Visible = false;
                textBox.Visible = false;
            }


            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = PlayingCard;
            pictureBox.MouseClick += PictureBox_MouseClick;
            pictureBox.DoubleClick += PictureBox_DoubleClick;
            pictureBox.ContextMenuStrip = ContextMenuStrip;
        }

        private void PictureBox_DoubleClick(object? sender, EventArgs e)
        {
            if (MouseDoubleClick != null)
            {
                MouseDoubleClick.Invoke(sender, e);
            }
        }

        private void PictureBox_MouseClick(object? sender, MouseEventArgs e)
        {
            if (MouseClick != null)
            {
                MouseClick(sender, e);
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (PlayingCard == null)
            {
                return;
            }

            var pair = PlayingCard.Counters[0];
            PlayingCard.Counters[0] = new KeyValuePair<string, int>(pair.Key, pair.Value - 1);
            textBox.Text = PlayingCard.Counters[0].Value.ToString();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (PlayingCard == null)
            {
                return;
            }

            var pair = PlayingCard.Counters[0];
            PlayingCard.Counters[0] = new KeyValuePair<string, int>(pair.Key, pair.Value + 1);
            textBox.Text = PlayingCard.Counters[0].Value.ToString();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
