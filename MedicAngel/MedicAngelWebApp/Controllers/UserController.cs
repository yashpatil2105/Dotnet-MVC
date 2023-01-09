using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicAngel.Models;
using DataAccessLayer;
using BussinessObjectLayer;
namespace MedicAngel.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
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
    {   List<User> users = (List<User>)DetailsManager.GetDetails();
        foreach(User user in users){
            if(user.email.Equals(email) && user.password.Equals(password)){
                return Redirect("/User/UserList");
            }
        }
        return Redirect("../User/Login");
 
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
        DetailsManager.WriteJson(new User(firstname, lastname ,email , password, gender, city, country));
        return Redirect("/User/Login");
        }
        return Redirect("../User/Register");
        
    }

    public IActionResult UserList()
    {     
        ViewData["Catlog"] = (List<User>)DetailsManager.GetDetails();
        return View();
    }

    public IActionResult UserDetails(string email)
    {
        List<User> users = (List<User>)DetailsManager.GetDetails();
        foreach(User u in users){
            if(email == u.email){
               ViewData["User"] = u;
                return View();
            }
        }
        return Redirect("/User/UserList");  
    }
    


    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
