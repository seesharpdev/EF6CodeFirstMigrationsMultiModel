using System;
using System.Collections.Generic;

namespace ModelTwo
{
    public class Blog
    {
        public Guid BlogId { get; set; }

        public string Topic { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
