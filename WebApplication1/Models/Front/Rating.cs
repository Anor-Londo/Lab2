using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Front
{
    public class Rating
    {

        public long UserId { get; set; }
        public long PostId { get; set; }
        public DateTime Date { get; set; }
        public int RatingValue { get; set; }
    }
}
