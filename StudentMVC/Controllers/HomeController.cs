using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using dal;
using bll;
using models;


namespace StudentMVC.Controllers;

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
    public IActionResult DisplayAll()
    {
        List<Student> lst= new List<Student>();
        lst=Service.getall();
        ViewData["dataAll"]=lst;
        
        return View();
    }
    
     public IActionResult Insertdata()
    {
        
        return View();
    }
     public IActionResult Updatedata()
    {
        return View();
    }
     public IActionResult Deletedata()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Updatedata(int Id,string Name,string Mobile)
    {
        
        string s=Service.Updatedata(Id,Name,Mobile);
        ViewData["Updateddata"]=s;
        return View();
    }
    [HttpPost]
    public IActionResult Deletedata(int Id)
    {
        
        string s=Service.Deletedata(Id);
        ViewData["deleteddata"]=s;
        return View();
    }
    

    [HttpPost]
    public IActionResult Insertdata(int Id,string Name,string Mobile)
    {
        
        string s=Service.Insertdata(Id,Name,Mobile);
        ViewData["data"]=s;
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
