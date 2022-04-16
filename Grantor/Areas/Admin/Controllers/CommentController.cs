using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var commenList = commentManager.GetLisInUser();
            return View(commenList);
        }
        public IActionResult UpdateComment(int id)
        {
            var comment = commentManager.GetByID(id);
            if (comment.Status != true)
            {
                comment.Status = true;
            }
            else
            {
                comment.Status = false;
            }
            commentManager.Update(comment);
            return RedirectToAction("Index");
        }
    }
}
