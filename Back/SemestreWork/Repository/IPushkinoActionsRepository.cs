using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SemestreWork.Models;

namespace SemestreWork.Repository
{
    public interface IPushkinoActionsRepository
    {
        int Add(PushkinoActionPost product);

        List<PushkinoActionPost> GetList();

        PushkinoActionPost GetNews(int id);

        int EditNews(PushkinoActionPost news);

        int DeleteNews(int id);
    }
}
