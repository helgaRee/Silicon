using Microsoft.AspNetCore.Mvc;
using Silicon_MVC.ViewModels;

namespace Silicon_MVC.Controllers;

public class AuthController : Controller
{
    //Genom att ange Route, behöver man inte nå sig up via auth: /auth/aignup
    //utan det räcker med /signup
    [Route("/signup")]
    [HttpGet]
    //IActionResult ger mig tillgång till vyer, parital vyer, statuskoder osv
    public IActionResult SignUp()
    {
        //skapar en modell
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    //skapar en route för SIgn up med POST, stoppar in en modell
    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        //Gör kontroll om formuläret är korrekt ifyllt
        //är formuläret ej korrekt ifyllt, gå tillbaka till Vyn. Annars...vadå?


        //skickar med in min modell för att komma åt title ur modellen

        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        else
        {
            return View(viewModel); // -> RedirectToAction("SignIn", "Auth");
        }


    }
}
