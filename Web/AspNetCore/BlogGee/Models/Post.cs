using System;
using System.Collections.Generic;

namespace BlogGee.Models
{
    public class Post
    {
        public string ID { get; set; } = DateTime.UtcNow.Ticks.ToString();

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PubDate { get; set; } = DateTime.UtcNow;

        public DateTime LastModified { get; set; } = DateTime.UtcNow;

        public bool IsPublished { get; set; } = true;

        public IList<string> Categories { get; set; } = new List<string>();
    }
}