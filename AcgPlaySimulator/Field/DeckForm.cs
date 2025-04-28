using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcgPlaySimulator.Field
{
    public partial class DeckForm : Form
    {
        public Panel Panel
        {
            get
            {
                return DeckPanel;
            }
        }

        public PlayingDeck? PlayingDeck
        {
            get;
            set;
        }

        public PlayingCard? SearchedCard
        {
            get;
            set;
        }

        public DeckForm()
        {
            InitializeComponent();
        }
        private void DeckForm_Load(object sender, EventArgs e)
        {
            if (PlayingDeck != null)
            {
                PlayingDeck.MainDeckSort();
                ViewPanel(DeckPanel, "Shiftで公開。　Ctrlで非公開でフリーに移動", PlayingDeck.MainDeck);
            }
        }

        private void ViewPanel(Panel panel, string title, List<PlayingCard> cards)
        {
            panel.Controls.Clear();

            Label label = new Label();
            label.Name = panel.Name + "Label";
            label.Text = title;
            label.Location = new Point(3, 0);
            label.Height = 15;
            panel.Controls.Add(label);

            int width = panel.Size.Width;
            int cardXDiff = 140;
            if (0 < cards.Count
                && width / cards.Count < 140)
            {
                cardXDiff = (width / cards.Count) - 2;
            }

            int index = cards.Count - 1;
            foreach (var card in cards)
            {
                var image = new PictureBox();
                label.Name = panel.Name + "Image" + (index).ToString();
                image.Size = card.IsMoved ? new Size(151, 105) : new Size(105, 151);
                var originalImage = card.CardInfo.Image;
                if (card.IsMoved)
                {
                    var flipImage = originalImage?.Clone() as Image;
                    flipImage?.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    image.Image = flipImage;
                }
                else
                {
                    image.Image = originalImage;
                }
                image.Location = new Point(1 + (index * cardXDiff), 18);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Tag = card;
                image.MouseClick += Image_MouseClick;
                panel.Controls.Add(image);

                index--;
            }
        }

        private void Image_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox
                && pictureBox.Tag is PlayingCard card)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    card.IsOpen = true;
                    SearchedCard = card;
                    DialogResult = DialogResult.OK;
                }
                else if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    card.IsOpen = false;
                    SearchedCard = card;
                    DialogResult = DialogResult.OK;
                }
            }
        }

    }
}
