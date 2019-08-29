using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AwesomeUpload.Models;
using Microsoft.AspNetCore.Http;

using System.IO;

namespace AwesomeUpload.Controllers
{
    public class HomeController : Controller
    {

        private IEnumerable<UserViewModel> _Users;

        public HomeController()
        {
           
        }
        public IActionResult Index()
        {

            var path = $@"C:\Development\images\00X0X_3Zrl0eVsxEX_1200x900.jpg";
            
            var uploadViewModel = new UploadViewModel()
            {
                FirstName = "John",
                LastName = "Smith",
                UserName = "JSmith",
                PerformDelete = false,
                FileName = "Yourfilename",
                FileExtension = ".jpg",
                FileSize = 140191,
                Image = System.IO.File.ReadAllBytes(path)
            };
            return View(uploadViewModel);
        }


        [HttpPost]
        public ActionResult Index(UploadViewModel viewModel)
        {
            //Save data here.
            if (viewModel.File != null)  //User added a new file
            {
                //Update or add file here.
            }
            else if (viewModel.PerformDelete)  //User clicked delete file
            {
                //Perform delete
            }

            viewModel.SuccessMessage = "Saved Successfully!";
            return View(viewModel);
        }


        public async Task<ActionResult> SaveAttachment(IFormFile File)  //Dummy function for async mode.
        {
            return Content("");
        }


        public ActionResult RemoveAttachment(string[] fileNames) //Dummy remove function
        {
            return Content("");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
