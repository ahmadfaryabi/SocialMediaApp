using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SocialMediaApp.Models;

namespace SocialMediaApp.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        return View();    
    }

    public IActionResult Register()
    {
        return View();    
    }
}