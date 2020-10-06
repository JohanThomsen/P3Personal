using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Linq;

namespace MenuProject
{
    class RSSMenuItem : Menu , IMenu
    {
        public RSSMenuItem(string Title, string rssUrl) :
            base(Title)
        {
            RSSUrl = rssUrl;
        }
        public string RSSUrl { get;}

        public override void Select()
        {
            XmlReader reader = XmlReader.Create(RSSUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                Add(new MenuItem(item.Title.Text, item.Summary.Text));
            }
            Start();
        }
    }
}
