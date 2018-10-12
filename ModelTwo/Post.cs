using System;

namespace ModelTwo
{
    public class Post
    {
        public Guid PostId { get; set; }

        public Guid BlogId { get; set; }

        public string Content { get; set; }
    }
}
