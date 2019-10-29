using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PodcastAppGUI());


            string url = @"https://www.theguardian.com/news/series/todayinfocus/podcast.xml?fbclid=IwAR0V0aVGZgxkfBBZxAI7hQn2VLlTZSvY_TA_hszdDBBRd-5IsMTw5rb_zBI";
            var a = new Podcast("Joe Rogan", url, "Advice", 100);
            //Console.WriteLine(a.Episodes[4].Description); This code works fine but this aint no console solution  
        }
    }
}
