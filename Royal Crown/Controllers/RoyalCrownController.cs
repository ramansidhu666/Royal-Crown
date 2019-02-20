using Royal_Crown.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Royal_Crown.Controllers
{
    public class RoyalCrownController : Controller
    {
        //
        // GET: /RoyalCrown/

        public ActionResult Index()
        {
            ViewBag.Title = "Energy Insulation Exterior Stucco Design Services Toronto";
            ViewBag.Description = "Royal Crown Stucco contractors bring you exterior stucco services, repair, ultimate designs & exterior insulated finish system. Hire Us Now!";
            return View();
        }
        public ActionResult about()
        {
            ViewBag.Title = "Best Stucco Contractors Toronto - Royal Crown Stucco";
            ViewBag.Description = "Royal Crown Stucco name as the best commercial & residential stucco contractors in Etobicoke, Mississauga, and Toronto. Contact us today at +1 647-863-3774.";
            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Title = "Contact us For Any Queries Related to Stucco Systems";
            ViewBag.Description = "Looking for any kind of stucco service, or repair service, Just Feel free to contact us at +1-647-863-3774 or via an email at info@royalcrownstucco.com.";
            return View();
        }
        public ActionResult Detail()
        {
            ViewBag.Title = "";
            ViewBag.Description = "";
            return View();
        }
        public ActionResult OurProjects()
        {
            ViewBag.Title = "Our Projects - Royal Crown Stucco";

            ViewBag.Description = "Take a look at our portfolio on our website. We have done work with completing every client's expectations & make them 100% satisfied. Explore Our Gallery!";
            return View();
        }
        public ActionResult services()
        {
            ViewBag.Title = "Stucco & EIFS System Consultation Service Providers Toronto";
            ViewBag.Description = "From Stucco Repair to External Insulated Finish systems, we deal with these services with aim of fulfilling client needs with the best materials available.";
            return View();
        }

        [HttpPost]
        public ActionResult sendmail(PersonModel person)
        {
            System.Threading.Thread.Sleep(2000);  /*simulating slow connection*/

            /*Do something with object person*/
            if (person != null)
            {
                SendEmail(person);
            }
            else
            {
                return Json(new { msg = "model empty " });
            }

            return Json(new { msg = "Successfully added " + person.Name });
        }

        public string SendEmail(PersonModel model)
        {
            var subject = "";
            if (model.subject != null)
            {
                subject = model.subject;
            }
            else
            {
                subject = "New Client Appointment";
            }

            string Status = "";
            

            //Send mail
            MailMessage mail = new MailMessage();

            string FromEmailID = WebConfigurationManager.AppSettings["RegFromMailAddress"];
            string FromEmailPassword = WebConfigurationManager.AppSettings["FromEmailPassword"];
            string ToEmail = WebConfigurationManager.AppSettings["ToEmailID"];

            SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
            int _Port = Convert.ToInt32(WebConfigurationManager.AppSettings["Port"].ToString());
            Boolean _UseDefaultCredentials = Convert.ToBoolean(WebConfigurationManager.AppSettings["UseDefaultCredentials"].ToString());
            Boolean _EnableSsl = Convert.ToBoolean(WebConfigurationManager.AppSettings["EnableSsl"].ToString());
            mail.To.Add(new MailAddress(ToEmail));
            mail.From = new MailAddress(FromEmailID);
            mail.Subject = subject;

            string msgbody = "";
            msgbody = "<p>Person Name : " + model.Name + "</p>";
            msgbody = msgbody + "<p>Email ID : " + model.email + "</p>";
            msgbody = msgbody + "<p>Phone Number : " + model.Phone + "</p>";
            msgbody = msgbody + "<p>Message : " + model.Message + "</p>";

            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            System.Net.Mail.AlternateView plainView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(System.Text.RegularExpressions.Regex.Replace(msgbody, @"<(.|\n)*?>", string.Empty), null, "text/plain");
            System.Net.Mail.AlternateView htmlView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(msgbody, null, "text/html");

            mail.AlternateViews.Add(plainView);
            mail.AlternateViews.Add(htmlView);
            // mail.Body = msgbody;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Host = "smtp.gmail.com"; //_Host;
            smtp.Port = _Port;
            //smtp.UseDefaultCredentials = _UseDefaultCredentials;
            smtp.Credentials = new System.Net.NetworkCredential(FromEmailID, FromEmailPassword);// Enter senders User name and password
            smtp.EnableSsl = _EnableSsl;
            smtp.Send(mail);

            return Status;
        }

    }
}
