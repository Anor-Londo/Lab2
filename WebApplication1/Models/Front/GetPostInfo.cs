using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DTO;

namespace WebApplication1.Models.Front
{
    public class GetPostInfo
    {
        public PostsFront Post { get; set; }
        public List<Comments> Comments { get; set; }
        public long Rating { get; set; }
    }
}
