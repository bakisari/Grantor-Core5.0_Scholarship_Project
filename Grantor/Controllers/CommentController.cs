using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Grantor.Areas.Admin.Controllers;
using Grantor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class CommentController : BaseController
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public CommentController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager) : base(userManager, signInManager, roleManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            AppUser user = userManager.FindByEmailAsync(User.Identity.Name).Result;

            comment.CommentValue = comment.CommentValue;
            comment.userId = user.Id;
            comment.Status = false;
            commentManager.Add(comment);
            return RedirectToAction("Index", "Home");
        }
    }
}
