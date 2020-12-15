using SemestreWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemestreWork.Repository
{
    public interface IRepository1
    {
        int Add(PushkinoActionPost product);

        List<PushkinoActionPost> GetList();

        PushkinoActionPost GetNews(int id);

        int EditNews(PushkinoActionPost product);

        int DeleteNews(int id);
    }
}
