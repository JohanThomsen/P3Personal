using System;
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
namespace MenuProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = InitiateExampleMenu();
            m.Start();

            /*string url = "http://www.dr.dk/nyheder/service/feeds/allenyheder";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                Console.WriteLine(item.Title.Text);
                Console.WriteLine(item.Summary.Text);
            }*/

        }

        private static Menu InitiateExampleMenu()
        {
            Menu m = new Menu("First");
            m.Add(new MenuItem("First point", "First Content"));
            m.Add(new MenuItem("Second point", "Second Content"));
            m.Add(new MenuItem("Third point", "Third Content"));
            m.Add(new MenuItem("Fourth point", "Fourth Content"));
            Menu sub = new Menu("SubMenu");
            sub.Add(new MenuItem("First Sub", "First sub content"));
            sub.Add(new MenuItem("Second Sub", "Second sub content"));
            m.Add(sub);
            m.Add(new InfiniteMenu("Infinite"));
            m.Add(new FileSystemMenu("Browse your C Drive", new DirectoryInfo("C:\\")));
            m.Add(new FileSystemMenu("Browse your D Drive", new DirectoryInfo("D:\\")));
            m.Add(new RSSMenuItem("Gaming News", "http://blog.dota2.com/feed/"));
            m.Add(new DRNewsMenu("DR News"));
            return m;
        }


    }
}
