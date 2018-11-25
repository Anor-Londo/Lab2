using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Front;

namespace WebApplication1.Services.Comm
{
    public interface ICommService
    {
        void DeleteComm(long commId);
        void PutComm(Comment comment);
        void PatchComm(long commId, Comment comment);
    
    }
}
