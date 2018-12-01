
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Front;
using WebApplication1.Services.Comm;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommController : ControllerBase
    {
        private readonly ICommService _commService;

        public CommController(ICommService commService)
        {
            _commService = commService;
        }


        [HttpDelete("delete-comm")]
        public ActionResult DeleteComm(int commId)
        {
            try
            {
                _commService.DeleteComm(commId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("put-comm")]
        public ActionResult PutComm(Comment comment)
        {
            try
            {
                _commService.PutComm(comment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        [HttpPatch("patch-comm")]
        public ActionResult PatchComm(int commId, Comment comment)
        {
            try
            {
                _commService.PatchComm(commId, comment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
