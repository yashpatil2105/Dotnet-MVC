using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicAngel.Models;
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
    {   List<User> users = (List<User>)Serial.GetDetails();
        foreach(User user in users){
            if(user.email.Equals(email) && user.password.Equals(password)){
                return Redirect("/Home/Details");
            }
        }
        return Redirect("/Home/Login");
 
    }

    public IActionResult Details()
    {     
        ViewData["Catlog"] = (List<User>)Serial.GetDetails();
        return View();
    }
    


    public IActionResult Insert(string firstname, string lastname, string email, string password, string gender, string city,string country)
    {    
        if(firstname!=null && lastname!=null && email!=null && password!=null && gender!=null && city!=null && country != null){
        if(gender=="option1"){
            gender="Male";
        }
        else if(gender=="option2"){
            gender="Female";
        }
        else{
            gender="Not Mentioned";
        }
        Serial.WriteJson(new User(firstname, lastname ,email , password, gender, city, country));
        return Redirect("/Home/Login");
        }
        return Redirect("/Home/Register");
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
