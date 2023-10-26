using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidacionEnvioFormularios.Models;

namespace ValidacionEnvioFormularios.Controllers;

public class HomeController : Controller{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index(){
        return View("Index");
    }

    [HttpPost("procesa/usuario")]
    public IActionResult ProcesaUsuario(Usuario usuario){
        if(ModelState.IsValid){
            return View("RegistroExitoso", usuario);
        }
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
