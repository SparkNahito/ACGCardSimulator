using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgPlaySimulator.Card
{
    public class CardBase
    {
        public CardBase() { }
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public Image? Image { get; set; }
        public string Text { get; set; } = "";
    }
}
