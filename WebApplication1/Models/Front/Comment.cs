using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Front
{
    public class Comment
    {
        public string Body { get; set; }
        public string Title { get; set; }
        public long Userid { get; set; }
        public long Postid { get; set; }
    }
}
