using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.ViewComponents.Comment
{
    public class CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.GetLisInUser().Where(x=>x.Status==true).ToList();
            return View(values);
        }
    }
}
