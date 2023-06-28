using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CompanyWebsite.Models;
using CompanyWebsiteLibrary.Data;

namespace CompanyWebsite.Controllers;

public class HomeController : Controller
{
    private readonly DataManager dataManager;

    public HomeController(DataManager dataManager)
    {
        this.dataManager = dataManager;
    }

    public IActionResult Index()
    {
        return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
    }

    public IActionResult Contacts()
    {
        return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
    }
}

