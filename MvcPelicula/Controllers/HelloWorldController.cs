using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string nombre, int numVeces = 1)
        {
            ViewBag.Mensaje = "Hola " + nombre;
            ViewBag.NumVeces = numVeces;
            return View();
        }


    }
}