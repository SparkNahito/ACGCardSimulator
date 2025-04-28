using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgPlaySimulator.Card
{
    public class CardInfoLoader
    {
        public Dictionary<string, CardInfo> CardInfos
        {
            get; set;
        } = new Dictionary<string, CardInfo>();
    }

    public class CardInfo
    {
        public string Image { get; set; }
        public string Name { get; set; }
    }
}
