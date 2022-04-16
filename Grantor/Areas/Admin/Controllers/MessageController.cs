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
    public class MessageController:Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository()); 
        public IActionResult InBox()
        {
            var messages = contactManager.AllList();
            var messagecount = contactManager.AllList().Count;
            ViewBag.messageCount = messagecount;
            return View(messages);
        }
        public IActionResult MessageDetails(int id)
        {
           var messageDetail= contactManager.GetByID(id);
            messageDetail.Status = true;
            contactManager.Update(messageDetail);
            return View(messageDetail);
        }
    }
}
