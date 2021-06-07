using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeConsole
{
    class Video
    {
        public string title { get; set; }

        public string description { get; set; }

        public List<Comments> comments { get; set; }

        public Video(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
