using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Front;

namespace WebApplication1.Repositories.Rating
{
    public interface IRatingRep
    {
        void PutRating(Models.Front.Rating rating);
        long GetRating(long postid);
    }
}
