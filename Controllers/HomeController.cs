using Microsoft.AspNetCore.Mvc;
using AwsLibrary.AWS.SNS;
using System.Threading.Tasks;

namespace SendResponseEmailUsingAWS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> Index(UserEmailModel userEmailModel)
        {
            await SimpleEmailServiceSNS.GetInstance().SendEmailTo(recieverAddress : userEmailModel.UserEmail, subject : userEmailModel.UserName, textBody : userEmailModel.UserMessage);

            return View();
        }
    }
}
