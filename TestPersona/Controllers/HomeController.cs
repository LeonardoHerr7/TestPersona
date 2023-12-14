using Microsoft.AspNetCore.Mvc;
using TestPersona.Entidades;
namespace TestPersona.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarPersona(Persona persona)
        {
            var personas = new Persona
            {
                Nombre = persona.Nombre,
                ApellidoPaterno = persona.ApellidoPaterno,
                ApellidoMaterno = persona.ApellidoMaterno
            };

            context.Add(personas);
            context.SaveChanges();
            ViewBag.Mensaje = "Persona agregada correctamente";

            return View("Index");
        }

    }
}