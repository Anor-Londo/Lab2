using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Front;
using WebApplication1.Repositories.Posts;
using WebApplication1.Repositories.Comm;

namespace WebApplication1.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IPostRep _postRep;
        private readonly ICommRep _commRep;

            
        public PostService(IPostRep postRep, ICommRep commRep)
        {
            _postRep = postRep;
            _commRep = commRep;
        }

        public void CreatePost(Post post)
        {
            _postRep.CreatePost(post);
        }

        public PostInfo PostInfo(long postId)
        {
            var post = _postRep.Post(postId);
            var comments = _commRep.CommentsToPost(postId);

            PostInfo postinf = new PostInfo
            {
                Post = post,
                Comments = comments
            };

            return postinf;
        }

        public List<PostsFront> PostsLists()
        {
           var posts =  _postRep.Posts();
             var cat = _postRep.Categories();
                var users = _postRep.Users();

            var result = posts.Join(
                            cat,
                            x => x.CategoryId,
                            x => x.Id,
                            (x, y) => new
                            {
                                Posts = x,
                                Cats = y
                            })
                              .Join(
                               users,
                               x => x.Posts.UserId,
                               x => x.Id,
                               (x, c) => new PostsFront()
                               {
                                   Id = x.Posts.Id,
                                   Title = x.Posts.Title,
                                   Body = x.Posts.Body,
                                   Description = x.Posts.Description,
                                   CategoryName = x.Cats.Name,
                                   Date = x.Posts.Date,
                                   UserName = c.Name
                               }).ToList();

              return result;
             
        }

        
    }
}
