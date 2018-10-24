using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace Podcast.Business_logic_layer
{
    public class Avsnitt
    {
        public string Namn { get; set; } // är setmetoden viktig att ha kvar?
        public decimal Langd { get; set; }

    }
}
