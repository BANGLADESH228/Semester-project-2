using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemestreWork.Models;
using SemestreWork.Repository;

namespace SemestreWork.Pages
{
    public class DuActionsModel : PageModel
    {
        IDuActions1Repository _Repository;
        public DuActionsModel(IDuActions1Repository Repository)
        {
            _Repository = Repository;
        }

        [BindProperty]
        public List<DuActionsPost> newsList { get; set; }

        [BindProperty]
        public DuActionsPost news { get; set; }

        public void OnGet()
        {
            newsList = _Repository.GetList();
        }
        public IActionResult OnPost()
        {
            string str = HttpUtility.HtmlEncode(news.Text);
            news.Text = str;

            if (ModelState.IsValid)
            {
                var count = _Repository.Add(news);
                if (count > 0)
                {
                    return RedirectToPage("/DuActions");
                }
            }

            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            if (id > 0)
            {
                var count = _Repository.DeleteNews(id);
                if (count > 0)
                {
                    return RedirectToPage("/DuActions");
                }
            }

            return Page();

        }
    }
}