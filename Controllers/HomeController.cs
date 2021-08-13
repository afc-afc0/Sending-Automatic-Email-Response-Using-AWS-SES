using Microsoft.AspNetCore.Mvc;
using AwsLibrary.AWS.SNS;
using AwsLibrary.AWS.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SendResponseEmailUsingAWS.Controllers
{
    public class HomeController : Controller
    {
        public readonly IMessageSender _messageSender;

        public HomeController(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> Index(UserMessageModel userMessageModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _messageSender.SendMessage(userMessageModel.UserName, userMessageModel.UserEmail, userMessageModel.UserMessage);

            return View();
        }
    }
}
