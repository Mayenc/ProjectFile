using Microsoft.AspNetCore.Mvc;

namespace ProjectFile.Areas.Files.Controllers
{
    [Area("Files")]
    public class FileManagerController : Controller
    {
        [Route("/file-manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
