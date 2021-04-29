using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleContactUsApp.Models;
namespace SampleContactUsApp.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactSave()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactSave(ContactUsForm contactUsForm)
        {
            SaveData(contactUsForm);
            ViewBag.Message = "Data Saved Successfully";
            return View();
        }
        public void SaveData(ContactUsForm contactUsForm)
        {
            string file = @"D:\\Temp\\Sampleapp.txt";
            var list = new List<ContactUsForm>();
            list.Add(contactUsForm);
            var arr = list.ToArray();

            using (StreamWriter writer = new StreamWriter(file))
            {

                foreach (var contact in arr)
                {
                    writer.WriteLine("Name :" + contact.FirstName + "/n" + "LastName :" + contact.LastName + "/n" + "Email :" + contact.Email + "/n" + "Message :" + contact.Message);
                }
            }

        }


    }
}