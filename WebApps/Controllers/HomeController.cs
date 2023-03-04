using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApps.Models;
using ConsoleAppProject.App02;

namespace WebApps.Controllers;

public class HomeController : Controller
{ 

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DistanceConverter()
    {
        return View();
    }

    [HttpGet]
    public IActionResult BmiCalculator()
    {
        return View();
    }

    [HttpPost]
    public IActionResult BmiCalculator (BmiCalculator bmi)
    {
        if (bmi.Centimetres > 140)
        {
            bmi.CalculateMetricBMI();
        }
        else if (bmi.Feet > 4 && bmi.Stones > 6)
        {
            ViewBag.Error = "You have entered value too small for any adut!";
            return View();
        }
        double bmiIndex = bmi.Index;
        return RedirectToAction("HealthMessage", new { bmiIndex });
    }

    public IActionResult HealthMessage(double bmiIndex )
    {
        return View(bmiIndex);
    }

    public IActionResult StudentMarks()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

