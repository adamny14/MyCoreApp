
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCoreApp.Controllers
{
    public class HelloWorldController : Controller
    {
       //GET: /HelloWorld/
       public string Index()
        {
            return "This is my default action...";
        }

        //GET HelloWorld/Welcome
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        // GET HellowWorld/Goodbye
        public string Goodbye()
        {
            return "Goodbye and have a nice day";
        }

    }
}
