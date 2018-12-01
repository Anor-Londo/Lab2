using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.DTO;
using WebApplication1.Models.Front;
using WebApplication1.Repositories.Comm;

namespace WebApplication1.Services.Comm
{
    public class CommService : ICommService
    {
        private readonly ICommRep _commRep;

        public CommService(ICommRep commRep)
        {
            _commRep = commRep;
        }

        public void DeleteComm(int commId)
        {
            _commRep.DeleteComm(commId);
        }  

        public void PutComm(Comment comment)
        {
            _commRep.PutComm(comment);
        }

        public void PatchComm(int commId, Comment comment)
        {
            _commRep.PatchComm(commId, comment);
        }
    }
}
