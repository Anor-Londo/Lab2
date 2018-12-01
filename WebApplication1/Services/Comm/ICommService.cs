using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Front;

namespace WebApplication1.Services.Comm
{
    public interface ICommService
    {
        void DeleteComm(int commId);
        void PutComm(Comment comment);
        void PatchComm(int commId, Comment comment);
    
    }
}
