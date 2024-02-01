using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;


public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View(); 
    }
}
public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}


public class NameController : Controller
{
    public string Index()
    {
        return "Tell your name in params";
    }

     public string Naam()
    {
        return $"Your name is ";
    }
}
public class FoodController : Controller
{

    public string Index()
    {
        return "Tell your favourite food";
    }
    public string Naami(string type, string hotOrCold)
    {
        return $"you like {type} and it is {hotOrCold}";
    }
        }
public class PetController : Controller
{

    public string Index()
    {
        return "Your favourite pet";

    }
    public string Naam2(string breed, string Bulldog)
    {
        return $"i like {breed} and it is {Bulldog}";
    }
}