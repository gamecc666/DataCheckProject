using DataCheckProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataCheckProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //自动映射
        public IActionResult PostData(UserInfo userinfo)
        {
            //验证是否有效
            return Content(ModelState.IsValid ? "模型数据有效" : "模型数据无效");
        }
    }
}