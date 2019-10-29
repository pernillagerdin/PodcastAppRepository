﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastApp
{
    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }


        public Episode(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
