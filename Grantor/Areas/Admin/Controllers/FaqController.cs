using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
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
    public class FaqController : Controller
    {
        FaqManager faqManager = new FaqManager(new EfFaqRepository());
        public IActionResult Index()
        {
            var values = faqManager.AllList();
            return View(values);
        }
        /**************** Add New Question ***************/
        public IActionResult AddFaq(Faq faq)
        {
            faqManager.Add(faq);
            return RedirectToAction("Index");
        }
        /************** Update Question ****************/
        [HttpGet]
        public IActionResult UpdateFaq(int id)
        {
            var faq = faqManager.GetByID(id);
            return View(faq);
        }

        [HttpPost]
        public IActionResult UpdateFaq(Faq faq)
        {
            var question = faqManager.GetByID(faq.ID);
            question.Title = faq.Title;
            question.Explanation = faq.Explanation;
            faqManager.Update(question);
            return RedirectToAction("Index");
        }
        /************* Delete Question **************/
        public IActionResult DeleteFaq(int id)
        {
           var faq= faqManager.GetByID(id);
            faqManager.Delete(faq);
            return RedirectToAction("Index");
        }
    }
}
