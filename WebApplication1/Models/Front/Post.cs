using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Front
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }
        public long UserId { get; set; }
    }
}
