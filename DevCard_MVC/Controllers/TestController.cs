using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Web.Helpers;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    //return Content("<h1> hello asp.net core mvc student</h1>");
        //    return Content("<h1 style='color:red'> hello asp.net core mvc student</h1> <script>confirm('qestion')</script>", contentType: "text/html");
        //}

        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //    //return null;
        //}

        //public FileResult Index()
        //{

        //    //return File(virtualPath:"~/test.txt", contentType: "text/html");

        //    //برای دانلود فایل از پایین استفاده میکنیم
        //    var fileByte = System.IO.File.ReadAllBytes(path: "wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte, contentType:MediaTypeNames.Text.Plain, fileName);
        //}


        //public JsonResult Index()
        //{
        //    return Json(data: new
        //    {
        //        id = 12,
        //        name = "Ehsan",
        //        job = "programmer",
        //        site = "ehsan.com"
        //    });
        //}


        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult(data: "alert('salam be hamegi')");
        //}


        //public RedirectResult Index()
        //{
        //    return Redirect(url: "https://www.varzesh3.com/");
        //}


        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", controllerName: "Home");
        //}



        public IActionResult Index()
        {
            //return new OkResult();
            //return new NotFoundResult();
            //return new BadRequestResult();
            //return new NoContentResult();
            //return new StatusCodeResult(896);
            return new StatusCodeResult(510);
        }
    }

    //public class JavaScriptResult : ContentResult
    //{
    //    public JavaScriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}
