using System;
using System.Collections.Generic;
using System.Text;

namespace MenuProject
{
    class DRNewsMenu : Menu, IMenu
    {
        public DRNewsMenu(string Title):
            base(Title)
        {
            try
            {
                Add(new RSSMenuItem("Alle nyheder", "https://www.dr.dk/nyheder/service/feeds/allenyheder"));
                Add(new RSSMenuItem("Indland", "https://www.dr.dk/nyheder/service/feeds/indland "));
                Add(new RSSMenuItem("Udland", "https://www.dr.dk/nyheder/service/feeds/udland "));
                Add(new RSSMenuItem("Penge", "https://www.dr.dk/nyheder/service/feeds/penge "));
                Add(new RSSMenuItem("Politik", "https://www.dr.dk/nyheder/service/feeds/politik "));
                Add(new RSSMenuItem("Kultur", "https://www.dr.dk/nyheder/service/feeds/kultur "));
                Add(new RSSMenuItem("Levnu", "https://www.dr.dk/nyheder/service/feeds/levnu "));
                Add(new RSSMenuItem("Viden", "https://www.dr.dk/nyheder/service/feeds/viden "));
                Add(new RSSMenuItem("Sporten", "https://www.dr.dk/nyheder/service/feeds/sporten "));
                Add(new RSSMenuItem("Vejret", "https://www.dr.dk/nyheder/service/feeds/vejret "));
                Add(new RSSMenuItem("Ligetil", "https://www.dr.dk/nyheder/service/feeds/ligetil "));
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }    
        }

        public override void Select()
        {
            base.Select();
        }
    }
}
