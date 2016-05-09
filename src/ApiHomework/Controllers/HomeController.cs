//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNet.Mvc;
//using ApiHomework.Models;

//// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//namespace ApiHomework.Controllers
//{
//    public class HomeController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult GetMessages()
//        {
//            var allMessages = Message.GetMessages();
//            return View(allMessages);
//        }

//        public IActionResult SendMessage()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult SendMessage(Message newMessage)
//        {
//            newMessage.Send();
//            return RedirectToAction("Index");
//        }
//    }
//}
