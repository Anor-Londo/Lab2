using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Front;
using WebApplication1.Models.DTO;

namespace WebApplication1.Repositories.Rating
{
    public class RatingRep : IRatingRep
    {
        public  RatingRep()
        {

        }

        public long GetRating(long postid)
        {
            using (var context = new PostgressContext())
            {
                long sum = 0;
                var ratingsList = context.Ratings.Where(x => x.PostId == postid).ToList();
                foreach (var item in ratingsList)
                {
                    sum = sum + item.RatingValue;
                }
                return sum / ratingsList.Count();
            }
        }

        public void PutRating(Models.Front.Rating rating)
        {
            using (var context = new PostgressContext())
            {
                context.Ratings.Add(new Ratings
                {
                    RatingValue = rating.RatingValue,
                    Date = DateTime.Now,
                    UserId = rating.UserId,
                    PostId = rating.PostId
                }
                );
                context.SaveChanges();
            }
        }
    }
}
