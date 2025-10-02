using AcgPlaySimulator.Card;
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
    public partial class SideBoardForm : Form
    {
        public PlayingDeck PlayingDeck
        {
            get;
            set;
        }

        public Action<PlayingCard> DetailFormShow
        {
            get; 
            set;
        }

        public SideBoardForm()
        {
            InitializeComponent();
        }

        private void SideBoardForm_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        public void ViewAll()
        {
            if (PlayingDeck == null)
            {
                return;
            }

            PlayingDeck.MainDeckSort();
            ViewPanel(MainDeckPanel, "メインデッキ（" + PlayingDeck.MainDeck.Count.ToString() + "枚）。Shiftでサイドアウト", PlayingDeck.MainDeck, false);
            ViewPanel(LandDeckPanel, "領土デッキ（" + PlayingDeck.LandDeck.Count.ToString() + "枚）。Shiftでサイドアウト", PlayingDeck.LandDeck, false);
            ViewPanel(SideDeckPanel, "予備デッキ（" + PlayingDeck.SideDeck.Count.ToString() + "枚）。Shiftでサイドイン", PlayingDeck.SideDeck, true);
        }


        private void ViewPanel(Panel panel, string title, List<PlayingCard> cards, bool isSide)
        {
            panel.Controls.Clear();

            Label label = new Label();
            label.Name = panel.Name + "Label";
            label.Text = title;
            label.Location = new Point(3, 0);
            label.Height = 15;
            label.AutoSize = true;
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
                image.Size = new Size(105, 151);
                var originalImage = card.CardInfo.Image;
                // サイドボーディング画面では、ムーブ状態を無視する
                image.Image = originalImage;
                image.Location = new Point(1 + (index * cardXDiff), 18);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Tag = card;
                if (isSide)
                {
                    image.MouseClick += SideImage_MouseClick;
                }
                else
                {
                    image.MouseClick += DeckImage_MouseClick;
                }

                image.MouseDoubleClick += Image_DoubleClick;
                panel.Controls.Add(image);

                index--;
            }
        }

        private void SideImage_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox
                && pictureBox.Tag is PlayingCard card)
            { 
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    if(card.CardInfo is LandDeckCard)
                    {
                        PlayingDeck.MoveCard(card, CardArea.LandDeck);
                    }
                    else
                    {
                        PlayingDeck.MoveCard(card, CardArea.MainDeck);
                    }

                    ViewAll();
                }
            }
        }

        private void DeckImage_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox
                && pictureBox.Tag is PlayingCard card)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    PlayingDeck.MoveCard(card, CardArea.SideDeck);
                    ViewAll();
                }
            }
        }

        private void Image_DoubleClick(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox
                && pictureBox.Tag is PlayingCard card)
            {
                DetailFormShow(card);
            }
        }
    }
}
