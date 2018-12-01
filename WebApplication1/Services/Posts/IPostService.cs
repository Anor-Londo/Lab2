using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Front;

namespace WebApplication1.Services.Posts
{
    public interface IPostService
    {
        List<PostsFront> PostsLists();
        PostInfo PostInfo(int postId);
        void CreatePost(Post post);
    }
}
