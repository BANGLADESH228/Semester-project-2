using SemestreWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SemestreWork.Repository
{
    public interface IRepository
    {
        int Add(DuActionsPost product);

        List<DuActionsPost> GetList();

        DuActionsPost GetNews(int id);

        int EditNews(DuActionsPost product);

        int DeleteNews(int id);
    }
}
