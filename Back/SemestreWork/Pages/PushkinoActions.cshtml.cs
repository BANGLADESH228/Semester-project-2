﻿using System;
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
    public class PushkinoActionModel : PageModel
    {
        IPushkinoActionsRepository _Repository;
        public PushkinoActionModel(IPushkinoActionsRepository Repository)
        {
            _Repository = Repository;
        }

        [BindProperty]
        public List<PushkinoActionPost> newsList { get; set; }

        [BindProperty]
        public PushkinoActionPost news { get; set; }

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
                    return RedirectToPage("/PushkinoActions");
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
                    return RedirectToPage("/PushkinoActions");
                }
            }

            return Page();

        }
    }
}