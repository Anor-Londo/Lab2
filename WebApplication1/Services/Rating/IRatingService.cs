using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Front;

namespace WebApplication1.Services.Rating
{
    public interface IRatingService
    {
        void PutRating(Models.Front.Rating rating);
        int GetRating(int postid);
    }
}
