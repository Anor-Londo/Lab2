using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.DTO;
using WebApplication1.Models.Front;

namespace WebApplication1.Repositories.Posts
{
    public interface IPostRep
    {
        List<Postss> Posts();
        List<Categories> Categories();
        List<Users> Users();
        Postss Post(long postId);
        void CreatePost(Post post);
    }
}
