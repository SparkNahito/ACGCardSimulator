using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgPlaySimulator.Card
{
    public class JsonDeck
    {
        public Dictionary<string, int> mainDeck { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> territoryDeck { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> reserveDeck { get; set; } = new Dictionary<string, int>();
        public string name { get; set; }
    }

    public class JsonCard
    {
        public string CardId { get; set; } = "";
        public int CardNumber { get; set; }
    }
}
