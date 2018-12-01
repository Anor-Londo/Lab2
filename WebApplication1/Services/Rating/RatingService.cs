using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Front;
using WebApplication1.Repositories.Rating;

namespace WebApplication1.Services.Rating
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRep _ratingRep;

        public RatingService(IRatingRep ratingRep)
        {
            _ratingRep = ratingRep;
        }

        public int GetRating(int postid)
        {
            return _ratingRep.GetRating(postid);
        }

        public void PutRating(Models.Front.Rating rating)
        {
            _ratingRep.PutRating(rating);
        }
    }
}
