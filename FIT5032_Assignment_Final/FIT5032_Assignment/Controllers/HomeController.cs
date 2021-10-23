using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIT5032_Assignment.Models;
using FIT5032_Assignment.Utils;

namespace FIT5032_Assignment.Controllers
{
    [ValidateInput(false)]
    /*
     * ValidateInput attribute at Controller level: 
     * The ValidateInput attribute can also be applied to a Controller and it will disable the validation by ASP.Net MVC for all the Action methods of that particular Controller.
     * Advantages
     * The Scope is limited to the specific Controller class.
     * If you have multiple Action methods accepting HTML content, then this method will reduce redundancy.
     * When Model class is not used for designing multiple Forms then this method is useful.
     * Disadvantages
     * All the Form fields posting data to all the Action methods can send HTML content, though only one or few might actually needed to send.
     */

    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Booking()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Send_Email()
        {
            return View(new SendEmailViewModel());
        }

        [HttpPost]
        public ActionResult Send_Email(SendEmailViewModel model, HttpPostedFileBase postedFileBase)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;

                    EmailSender es = new EmailSender();
                    es.Send(toEmail, subject, contents, postedFileBase);

                    ViewBag.Result = "Email has been send.";

                    ModelState.Clear();

                    return View(new SendEmailViewModel());
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }
    }
}