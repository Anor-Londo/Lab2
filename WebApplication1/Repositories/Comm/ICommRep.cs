using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DTO;
using WebApplication1.Models.Front;

namespace WebApplication1.Repositories.Comm
{
    public interface ICommRep
    {
        List<Comments> CommentsToPost(int postId);
        void DeleteComm(int commId);
        void PutComm(Comment comment);
        void PatchComm(int commId, Comment comment);
    }
}
