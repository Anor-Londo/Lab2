
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Front;
using WebApplication1.Services.Posts;
using WebApplication1.Services.Rating;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {

        private readonly IRatingService _ratingService;
        private readonly IPostService _postser;

        public PostsController(IPostService postser, IRatingService ratingService)
        {
            _postser = postser;
            _ratingService = ratingService;
        }


        [HttpGet("posts")]
        public ActionResult<List<PostsFront>> GetAllPosts(int skip, int take)
        {
           return _postser.PostsLists().Skip(skip).Take(take).ToList();
        }

        [HttpPost("post-info")]
        public ActionResult<GetPostInfo> GetPostInfo(long post_id)
        {
            var c = _postser.PostsLists().Find(x => x.Id == post_id);
            var a = _postser.PostInfo(post_id);
            var b = _ratingService.GetRating(post_id);
            GetPostInfo postInfo = new GetPostInfo
            {
                Post = c,
                Comments = a.Comments,
                Rating = b
            };
            return postInfo;
        }


        [HttpPut("insert-post")]
        public ActionResult CreatePost(Post post)
        {
            try
            {
                _postser.CreatePost(post);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

       
    }
}
