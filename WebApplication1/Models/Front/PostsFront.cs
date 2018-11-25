using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PostsFront
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }

    }
}
