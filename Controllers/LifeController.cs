using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
public class LifeController : Controller {

    public IActionResult Index(){
        return Ok("Life Controller Area");
    }

    public IActionResult Quote(){
        Quote quote = new Quote
        {Id = 345, Product = "Life Insurance", ExpireDate = DateTime.Now.AddDays(45), Price = 45.00M};
        
        return View(quote);
    }
}
