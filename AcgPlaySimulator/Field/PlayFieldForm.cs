using AcgPlaySimulator.Card;
using Microsoft.VisualBasic.Devices;
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
    public partial class PlayFieldForm : Form
    {
        public PlayFieldForm(Deck deck)
        {
            Deck = deck;
            PlayingDeck = new PlayingDeck(Deck);
            ReversedImage = System.Drawing.Image.FromFile(@".\Image\ACG-Back.jpg");
            InitializeComponent();

            DoubleBuffered = true;
        }

        public Deck Deck { get; }
        public PlayingDeck PlayingDeck { get; set; }
        private Image ReversedImage { get; }

        private void PlayFieldForm_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void ViewAll()
        {
            this.SuspendLayout();

            ViewPanel(handPanel, "手札 " + PlayingDeck.HandCards.Count.ToString() + "枚", PlayingDeck.HandCards);
            ViewPanel(freePanel, "フリーゾーン", PlayingDeck.FreeCards);
            ViewPanel(LandPanel, "領地", PlayingDeck.LandCards);
            ViewPanel(FieldPanel, "戦場", PlayingDeck.FieldCards);
            ViewPanel(RemovePanel, "除外", PlayingDeck.RemoveCards);
            ViewPanel(CemeteryPanel, "墓地", PlayingDeck.CemeteryCards);

            MainNnmberLabel.Text = PlayingDeck.MainDeck.Count.ToString() + "枚";
            LandNumberLabel.Text = PlayingDeck.LandDeck.Count.ToString() + "枚";

            if (DeliveryForm != null)
            {
                try
                {
                    DeliveryForm.ViewAll();
                }
                catch { }
            }

            this.ResumeLayout();
        }

        private void ViewPanel(Panel panel, string title, List<PlayingCard> cards)
        {
            List<Control> disposeControls = new List<Control>();
            foreach (Control control in panel.Controls) 
            {
                disposeControls.Add(control);
            }

            panel.Controls.Clear();

            foreach (Control control in disposeControls)
            {
                try
                {
                    control.Dispose();
                }
                catch { }
            }

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
                try
                {
                    var image = new FieldCardImageControl();
                    image.ReversedImage = ReversedImage;
                    image.Name = panel.Name + "Image" + (index).ToString();
                    image.Size = card.IsMoved ? new Size(151, 105) : new Size(105, 151);
                    image.Location = new Point(1 + (index * cardXDiff), 18);
                    image.PlayingCard = card;
                    image.Tag = card;
                    image.MouseClick += Image_MouseClick;
                    image.MouseDoubleClick += Image_DoubleClick;
                    image.ContextMenuStrip = ImageContextMenuStrip;

                    panel.Controls.Add(image);

                    index--;
                }
                catch
                {
                    GC.Collect();
                }
            }
        }

        private void Image_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox
                && pictureBox.Tag is PlayingCard card)
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    // 詳細見る様にムーブ処理を回避
                }
                else if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    PlayingDeck.MoveCard(card, CardArea.Moving);
                    ViewAll();
                }
                else if (card.CanTap)
                {
                    card.IsMoved = !card.IsMoved;
                    ViewAll();
                }
            }
        }

        private void MainDrawButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.MainDeck.Count == 0)
            {
                return;
            }

            var card = PlayingDeck.MainDeck[0];
            PlayingDeck.MoveCard(card, CardArea.Hand);
            ViewAll();
        }
        private void MainOpenButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.MainDeck.Count == 0)
            {
                return;
            }

            var card = PlayingDeck.MainDeck[0];
            PlayingDeck.MoveCard(card, CardArea.FreeOpen);
            ViewAll();
        }

        private void MainCheckButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.MainDeck.Count == 0)
            {
                return;
            }

            var card = PlayingDeck.MainDeck[0];
            PlayingDeck.MoveCard(card, CardArea.FreeClose);
            ViewAll();
        }

        private void MainShuffleButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.MainDeck.Count == 0)
            {
                return;
            }

            PlayingDeck.MainDeckShuffle();
        }
        private void LandOpenButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.LandDeck.Count == 0)
            {
                return;
            }

            var card = PlayingDeck.LandDeck[0];
            PlayingDeck.MoveCard(card, CardArea.Land);
            ViewAll();
        }

        private void LandCheckButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.LandDeck.Count == 0)
            {
                return;
            }

            var card = PlayingDeck.LandDeck[0];
            PlayingDeck.MoveCard(card, CardArea.FreeClose);
            ViewAll();
        }

        private void LandShuffleButton_Click(object sender, EventArgs e)
        {
            if (PlayingDeck.LandDeck.Count == 0)
            {
                return;
            }

            PlayingDeck.LandDeckShuffle();
        }

        private PlayingCard? GetItemToCard(object sender)
        {
            if (sender is ToolStripDropDownItem toolItem)
            {
                var menu = toolItem.GetCurrentParent();
                return GetMenuToCard(menu!);
            }
            return null;
        }

        private PlayingCard? GetMenuToCard(object sender)
        {
            if (sender is ContextMenuStrip menuStrip)
            {
                var source = menuStrip.SourceControl;
                if (source is PictureBox pictureBox)
                {
                    if (pictureBox.Tag is PlayingCard card)
                    {
                        return card;
                    }
                }
            }
            return null;
        }

        private void 裏にするToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var card = GetItemToCard(sender);
            if (card != null)
            {
                card.IsReversed = !card.IsReversed;
                ViewAll();
            }
        }

        private void 戦場に移動するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var card = GetItemToCard(sender);
            if (card != null)
            {
                PlayingDeck.MoveCard(card, CardArea.Field);
                ViewAll();
            }
        }
        private void 墓地に移動するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var card = GetItemToCard(sender);
            if (card != null)
            {
                PlayingDeck.MoveCard(card, CardArea.Cemetery);
                ViewAll();
            }
        }

        private void 除外に移動するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var card = GetItemToCard(sender);
            if (card != null)
            {
                PlayingDeck.MoveCard(card, CardArea.Remove);
                ViewAll();
            }
        }
        private void 手札に移動するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var card = GetItemToCard(sender);
            if (card != null)
            {
                PlayingDeck.MoveCard(card, CardArea.Hand);
                ViewAll();
            }
        }

        private void MainTopMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpeingContextMenuCard == null)
            {
                return;
            }

            if (OpeingContextMenuCard is PlayingCard card
                && card.CardInfo is BaseDeckCard)
            {
                PlayingDeck.RemoveCard(OpeingContextMenuCard);
                PlayingDeck.MainDeck.Insert(0, card);
                PlayingDeck.AddLog("カードをメインデッキの上に戻しました");
            }
            ViewAll();
        }

        private void MainBottomMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpeingContextMenuCard == null)
            {
                return;
            }

            if (OpeingContextMenuCard is PlayingCard card
                && card.CardInfo is BaseDeckCard)
            {
                PlayingDeck.RemoveCard(OpeingContextMenuCard);
                PlayingDeck.MainDeck.Add(card);
                PlayingDeck.AddLog("カードをメインデッキの下に戻しました");
            }
            ViewAll();
        }
        private void LandTopMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpeingContextMenuCard == null)
            {
                return;
            }

            if (OpeingContextMenuCard is PlayingCard card
                && card.CardInfo is LandDeckCard)
            {
                PlayingDeck.RemoveCard(OpeingContextMenuCard);
                PlayingDeck.LandDeck.Insert(0, card);
                PlayingDeck.AddLog("カードを領地デッキの上に戻しました");
            }
            ViewAll();
        }

        private void LandBottomMoveToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (OpeingContextMenuCard == null)
            {
                return;
            }
            if (OpeingContextMenuCard is PlayingCard card
                && card.CardInfo is LandDeckCard)
            {
                PlayingDeck.RemoveCard(OpeingContextMenuCard);
                PlayingDeck.LandDeck.Add(card);
                PlayingDeck.AddLog("カードを領地デッキの下に戻しました");
            }
            ViewAll();
        }
        PlayingCard? OpeingContextMenuCard { get; set; }
        private void ImageContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            OpeingContextMenuCard = GetMenuToCard(sender);
        }

        DetailForm? DetailForm = null;

        private void 詳細確認toolStripMenuItem_Click(object sender, EventArgs e)
        {
            var card = GetItemToCard(sender);
            if (card == null)
            {
                return;
            }
            DetailFormShow(card);
        }

        private void Image_DoubleClick(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox
                && pictureBox.Tag is PlayingCard card)
            {
                DetailFormShow(card);
            }
        }

        private void DetailFormShow(PlayingCard card)
        {
            if (card.CardInfo.Image == null)
            {
                return;
            }

            Point? location = null;
            if (DetailForm != null)
            {
                try
                {
                    location = DetailForm?.Location;
                    DetailForm?.Dispose();
                }
                catch { }
            }

            DetailForm = new DetailForm();
            DetailForm.Image = card.CardInfo.Image;
            DetailForm.Show();
            if (location != null)
            {
                DetailForm.Location = location.Value;
            }
        }

        private void 起床button_Click(object sender, EventArgs e)
        {
            PlayingDeck.Wake();
            ViewAll();
        }

        private void 墓地ソートbutton_Click(object sender, EventArgs e)
        {
            PlayingDeck.CemeterySort();
            ViewAll();
        }

        private void CounterToValue(string counterName, int number)
        {
            if (OpeingContextMenuCard == null)
            {
                return;
            }

            if (OpeingContextMenuCard is PlayingCard card)
            {
                card.Counters.Add(new KeyValuePair<string, int>(counterName, number));
                ViewAll();
            }
        }

        private void 個ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterToValue("unknown", 1);
        }
        private void 個ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CounterToValue("unknown", 2);
        }

        private void 個ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CounterToValue("unknown", 3);
        }

        private void 個ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CounterToValue("unknown", 4);
        }

        private void five個ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CounterToValue("unknown", 5);
        }

        private void 個ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CounterToValue("unknown", 6);
        }

        private void MainSearchButton_Click(object sender, EventArgs e)
        {
            using (var form = new DeckForm())
            {
                PlayingDeck.AddLog("カードを探しています");
                if (DeliveryForm != null)
                {
                    try
                    {
                        DeliveryForm.ViewLogs();
                    }
                    catch { }
                }

                form.PlayingDeck = PlayingDeck;
                form.ShowDialog();
                PlayingDeck.MainDeckShuffle();

                if (form.SearchedCard != null)
                {
                    PlayingDeck.MoveCard(form.SearchedCard, form.SearchedCard.IsOpen ? CardArea.FreeOpen : CardArea.FreeClose);
                    ViewAll();
                }
            }
        }

        private void FieldPanel_Click(object sender, EventArgs e)
        {
            if (0 < PlayingDeck.MovingCards.Count)
            {
                foreach (var card in PlayingDeck.MovingCards.ToList())
                {
                    PlayingDeck.MoveCard(card, CardArea.Field);
                }

                ViewAll();
            }
        }

        private void LandPanel_Click(object sender, EventArgs e)
        {
            if (0 < PlayingDeck.MovingCards.Count)
            {
                foreach (var card in PlayingDeck.MovingCards.ToList())
                {
                    PlayingDeck.MoveCard(card, CardArea.Land);
                }

                ViewAll();
            }
        }

        private void handPanel_Click(object sender, EventArgs e)
        {
            if (0 < PlayingDeck.MovingCards.Count)
            {
                foreach (var card in PlayingDeck.MovingCards.ToList())
                {
                    PlayingDeck.MoveCard(card, CardArea.Hand);
                }

                ViewAll();
            }
        }

        private void CemeteryPanel_Click(object sender, EventArgs e)
        {
            if (0 < PlayingDeck.MovingCards.Count)
            {
                foreach (var card in PlayingDeck.MovingCards.ToList())
                {
                    PlayingDeck.MoveCard(card, CardArea.Cemetery);
                }

                ViewAll();
            }
        }

        private void RemovePanel_Click(object sender, EventArgs e)
        {
            if (0 < PlayingDeck.MovingCards.Count)
            {
                foreach (var card in PlayingDeck.MovingCards.ToList())
                {
                    PlayingDeck.MoveCard(card, CardArea.Remove);
                }

                ViewAll();
            }
        }

        private void freePanel_Click(object sender, EventArgs e)
        {
            if (0 < PlayingDeck.MovingCards.Count)
            {
                foreach (var card in PlayingDeck.MovingCards.ToList())
                {
                    PlayingDeck.MoveCard(card, CardArea.FreeOpen);
                }

                ViewAll();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PlayingDeck.Life = (int)numericUpDown1.Value;
            if (DeliveryForm != null)
            {
                try
                {
                    DeliveryForm.ViewLife();
                }
                catch { }
            }
        }

        private void TokenButton_Click(object sender, EventArgs e)
        {
            string loadFilePath;
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "トークン画像を選択して下さい";

                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                loadFilePath = dialog.FileName;
            }

            PlayingCard tokenCard = new PlayingCard();
            tokenCard.CardInfo = new CardBase()
            {
                Image = Image.FromFile(loadFilePath)
            };
            PlayingDeck.MoveCard(tokenCard, CardArea.Field_Token);
            ViewAll();

        }

        DeliveryForm? DeliveryForm = null;
        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            if (DeliveryForm != null)
            {
                try
                {
                    DeliveryForm.Dispose();
                    DeliveryForm = null;
                }
                catch { }
            }

            DeliveryForm = new DeliveryForm(PlayingDeck);
            DeliveryForm.ReversedImage = ReversedImage;

            DeliveryForm.Show();
        }

        private void SideButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("盤面リセットされます宜しいですか？", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            PlayingDeck.Reset();

            ViewAll();
        }
    }
}
