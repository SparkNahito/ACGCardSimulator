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
    public partial class DeliveryForm : Form
    {
        public PlayingDeck PlayingDeck { get; }
        public Image ReversedImage { get; set; }

        public DeliveryForm(PlayingDeck playingDeck)
        {
            InitializeComponent();
            PlayingDeck = playingDeck;
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        public void ViewAll()
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

            numericUpDown1.Value = PlayingDeck.Life;

            LogTextBox.Text = "";
            foreach(var log in PlayingDeck.Logs)
            {
                LogTextBox.Text += log.ToString() + @"
";
            }

            this.ResumeLayout();
        }

        public void ViewLife()
        {
            numericUpDown1.Value = PlayingDeck.Life;
        }

        public void ViewLogs()
        {
            LogTextBox.Text = "";
            foreach (var log in PlayingDeck.Logs)
            {
                LogTextBox.Text += log.ToString() + @"
";
            }
        }

        private void ViewPanel(Panel panel, string title, List<PlayingCard> cards)
        {
            foreach (Control control in panel.Controls)
            {
                try
                {
                    control.Dispose();
                }
                catch { }
            }

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
                var image = new FieldCardImageControl();
                image.IsDelivery = true;
                image.ReversedImage = ReversedImage;
                image.Name = panel.Name + "Image" + (index).ToString();
                image.Size = card.IsMoved ? new Size(151, 105) : new Size(105, 151);
                image.Location = new Point(1 + (index * cardXDiff), 18);
                image.PlayingCard = card;
                image.Tag = card;
                panel.Controls.Add(image);

                index--;
            }
        }


    }
}
