using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ConfigExample _configExample;

    public HomeController(ConfigExample configExample)
    {
        _configExample = configExample;
    }

    public IActionResult Index()
    {
        ViewBag.ConnectionString = _configExample.ConnectionString;
        ViewBag.BlobConnectionString = _configExample.BlobConnectionString;
        ViewBag.JwtSignGuid = _configExample.JwtSignGuid;
        ViewBag.EmailServiceApiKey = _configExample.EmailServiceApiKey;

        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.ConnectionString = _configExample.ConnectionString;
        ViewBag.BlobConnectionString = _configExample.BlobConnectionString;
        ViewBag.JwtSignGuid = _configExample.JwtSignGuid;
        ViewBag.EmailServiceApiKey = _configExample.EmailServiceApiKey;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}