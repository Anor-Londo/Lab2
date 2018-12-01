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
        public int Userid { get; set; }
        public int Postid { get; set; }
    }
}
