using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgPlaySimulator.Card
{
    public class BaseDeckCard : CardBase
    {
        public int Cost;
        List<ColorCondition> ColorConditions = new List<ColorCondition>();
    }

    public enum ColorCondition
    {
        None = 0,
        Watar = 1,
        Wood = 2,
        Mountain = 3,
        Plain = 4,
    }
}
