using System.Collections.Generic;
using System.Xml;


namespace PodcastApp {
    public class Podcast
    {
        public string NameSetByUser { get; set; }
        public int UpdateFrequency { get; set; }
        public string Category { get; set; } //might change to enum? not required so not prioritised
        public string Url { get; set; }

        public List<Episode> Episodes = new List<Episode>();
        //public List<Episode> Episodes { get; set; }

        public Podcast(string nameSetByUser, string url, string category, int updateFrequency)
        {
            Url = url;
            Category = category;
            UpdateFrequency = updateFrequency;
            NameSetByUser = nameSetByUser;

            XmlDocument rssXmlDoc = new XmlDocument();

            // Load the RSS file from the RSS URL
            //rssXmlDoc.Load("https://www.theguardian.com/news/series/todayinfocus/podcast.xml?fbclid=IwAR0V0aVGZgxkfBBZxAI7hQn2VLlTZSvY_TA_hszdDBBRd-5IsMTw5rb_zBI");
            rssXmlDoc.Load(url);
            
            // Parse the Items in the RSS file
            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            Episodes = createEpisodesList(rssNodes);
        }

        private static List<Episode> createEpisodesList (XmlNodeList rssNodes)
        {
            List<Episode> ep = new List<Episode>();
            
            // Iterate through the items in the RSS file
            foreach (XmlNode rssNode in rssNodes)
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode(@"itunes:subtitle"); //changed from description to subtitle node since it gives same relevant info, just without ads
                string description = rssSubNode != null ? rssSubNode.InnerText : "";
               
                ep.Add(new Episode(title, description));
            }
            return ep;
        }
    }
}
