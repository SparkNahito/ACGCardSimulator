using AcgPlaySimulator.Card;
using AcgPlaySimulator.Field;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;

namespace AcgPlaySimulator
{
    public partial class DeckLoadForm : Form
    {
        public DeckLoadForm()
        {
            InitializeComponent();
        }

        private void DeckLoadForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string loadFilePath;
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "デッキを選択して下さい";

                if(dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                loadFilePath = dialog.FileName;
            }

            string deckJson;
            using (var stream = new System.IO.StreamReader(loadFilePath))
            {
                deckJson = stream.ReadToEnd();
            }

            JsonDeck jsonDeck = JsonSerializer.Deserialize(deckJson, typeof(JsonDeck)) as JsonDeck ?? new JsonDeck();

            string readInfo;
            using (var stream = new System.IO.StreamReader(@".\CardInfo.Json"))
            {
                readInfo = stream.ReadToEnd();
            }

            CardInfoLoader options = JsonSerializer.Deserialize(readInfo, typeof(CardInfoLoader)) as CardInfoLoader ?? new CardInfoLoader();

            Deck deck = new Deck();
            foreach(var pair in jsonDeck.mainDeck)
            {
                var card = IdToCard<BaseDeckCard>(pair.Key, options);
                if(card == null)
                {
                    continue;
                }
                for (int i = 0; i < pair.Value; ++i)
                {
                    deck.BaseCards.Add(card);
                }
            }
            foreach (var pair in jsonDeck.territoryDeck)
            {
                var card = IdToCard<LandDeckCard>(pair.Key, options);
                if (card == null)
                {
                    continue;
                }
                for (int i = 0; i < pair.Value; ++i)
                {
                    deck.LandCards.Add(card);
                }
            }
            foreach (var pair in jsonDeck.reserveDeck)
            {
                var card = IdToCard<CardBase>(pair.Key, options);
                if (card == null)
                {
                    continue;
                }
                for (int i = 0; i < pair.Value; ++i)
                {
                    deck.ReserveCards.Add(card);
                }
            }

            var form = new PlayFieldForm(deck);
            form.Show();
        }

        private T? IdToCard<T>(string id, CardInfoLoader cardInfoLoader) where T : CardBase, new()
        {
            if (!cardInfoLoader.CardInfos.ContainsKey(id))
            {
                // TODO 警告メッセージ欲しい
                return null;
            }
            var info = cardInfoLoader.CardInfos[id];
            var image = System.Drawing.Image.FromFile(@".\Image\" + info.Image);
            var card = new T();
            card.Id = id;
            card.Image = image;
            card.Name = info.Name;
            return card;
        }

    }
}
