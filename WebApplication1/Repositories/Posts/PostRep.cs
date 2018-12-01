using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.DTO;
using WebApplication1.Models.Front;

namespace WebApplication1.Repositories.Posts
{
    public class PostRep: IPostRep
    {
        public PostRep()
        {

        }

        public List<Postss> Posts()
        {
            using (var context = new PostgressContext())
            {
                return context.Posts.ToList();
            }
        }

        public List<Categories> Categories()
        {
            using (var context = new PostgressContext())
            {
                    return  context.Categories.ToList();
            
            }
        }

        public List<Users> Users()
        {
            using (var context = new PostgressContext())
            {
                    return context.Users.ToList();
             
            }
        }

        public Postss Post(int postId)
        {
            using (var context = new PostgressContext())
            {
                return context.Posts.FirstOrDefault(x => x.Id == postId);
            }
        }

        public void CreatePost(Post post)
        {
            using (var context = new PostgressContext())
            {
              context.Posts.Add(new Postss()
              {
                    Title = post.Title,
                    Body = post.Body,
                    Description = post.Description,
                    CategoryId = post.CategoryId,
                     Date = DateTime.Now,
                    UserId = post.UserId
              }
              );

                context.SaveChanges();
            }
        }
    }
}
