using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.DTO;
using WebApplication1.Models.Front;

namespace WebApplication1.Repositories.Comm
{
    public class CommRep : ICommRep
    {
        public CommRep()
        {

        }


        public List<Comments> CommentsToPost(int postId)
        {
            using (var context = new PostgressContext())
            {
                 return context.Comments.Where(x => x.PostId == postId).ToList();
    
            }
        }


        public void DeleteComm(int commId)
        {
            using (var context = new PostgressContext())
            {
                Comments comment = context.Comments.Where(x => x.Id == commId).FirstOrDefault();
                context.Comments.Remove(comment);
                context.SaveChanges();
            }
        }

        public void PutComm(Comment comment)
        {
            using (var context = new PostgressContext())
            {
                context.Comments.Add(new Comments
                {
                    Body = comment.Body,
                    Title = comment.Title,
                    UserId = comment.Userid,
                    PostId = comment.Postid
                }
                );

                context.SaveChanges();
            }
        }

        public void PatchComm(int commId, Comment comment)
        {
            using (var context = new PostgressContext())
            {
                Comments _comment = context.Comments.Where(x => x.Id == commId).FirstOrDefault();
                _comment.Body = comment.Body;
                _comment.PostId = comment.Postid;
                _comment.Title = comment.Title;
                _comment.UserId = comment.Userid;
                context.SaveChanges();
            }
        }
    }
}

