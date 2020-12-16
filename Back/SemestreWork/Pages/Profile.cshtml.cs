using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemestreWork.Models;
using SemestreWork.Repository;

namespace SemestreWork.Pages
{
    public class ProfileModel : PageModel
    {
        IRegisterRepository _usersRepository;
        ICommentsRepository _commentsRepository;
        public ProfileModel(IRegisterRepository usersRepository, ICommentsRepository commentsRepository)
        {
            _usersRepository = usersRepository;
            _commentsRepository = commentsRepository;
        }

        [BindProperty]
        public Comments comment { get; set; }

        public List<Comments> AllComments{ get; set; }

        [BindProperty]
        public RegisterModel user { get; set; }

        public int Id { get; set; }
        public void OnGet(int id)
        {
            Id = id;
            user = _usersRepository.GetUser(id);

            AllComments = _commentsRepository.GetList(id);

            foreach (var a in AllComments)
            {
                if (AllComments == null)
                {
                    AllComments = new List<Comments>();
                }
                AllComments.AddRange(_commentsRepository.GetList(a.Id));
            }
        }
        
        public IActionResult StatusCreate(int id)
        {
            var userEdit1 = _usersRepository.GetUser(id);
            userEdit1.Status = user.Status;

            user = userEdit1;
            if (ModelState.IsValid)
            {
                var count = _usersRepository.EditUser(userEdit1);
                if (count > 0)
                {
                    return Redirect("/Profile/" + id);
                }
            }

            return Page();
        }

        public IActionResult OnPostEdit(int id)
        {
            var userEdit = _usersRepository.GetUser(id);
            userEdit.Image = user.Image;
            userEdit.Name = user.Name;
            userEdit.Surname = user.Surname;
            userEdit.Years = user.Years;
            userEdit.Campus = user.Campus;
            userEdit.Course = user.Course;
            userEdit.Status = user.Status;

            user = userEdit;
            if (ModelState.IsValid)
            {
                var count = _usersRepository.EditUser(userEdit);
                if (count > 0)
                {
                    return Redirect("/Profile/" + id);
                }
            }

            return Page();
        }

        public IActionResult OnPostSendComment(int id)
        {
            var a = HttpContext.Session.Get<RegisterModel>("AuthUser");
            comment.CreatorId = a.Id;
            comment.CreatorName = a.Name + a.Surname;
            if (ModelState.IsValid)
            {
                var count = _commentsRepository.Add(comment);
                if (count > 0)
                {
                    return Redirect("/Profile/" + id);
                }
            }

            return Redirect("/Profile/" + id);
        }
    }
}