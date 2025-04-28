using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgPlaySimulator.Card
{
    public class Deck
    {
        public List<BaseDeckCard> BaseCards { get; set; } = new List<BaseDeckCard>();
        public List<LandDeckCard> LandCards { get; set; } = new List<LandDeckCard>();

        public List<CardBase> ReserveCards { get; set; } = new List<CardBase>();

    }


}
