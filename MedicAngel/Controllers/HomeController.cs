using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicAngel.Models;
using Info;
namespace MedicAngel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult validate(string email, string password)
    {    
        Console.Write(email);
        Console.Write(password);
        return Redirect("/Home/Register");
 
    }

    public IActionResult Details()
    {     
        return View();
    }
    
    List<User> users = new List<User>();

    public IActionResult Insert(string firstname, string lastname,string email, string password)
    {    
        users.Add(new User(firstname, lastname ,email , password));
        Serial s = new Serial();
        s.iserial(users);
        return Redirect("/Home/Details");
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
