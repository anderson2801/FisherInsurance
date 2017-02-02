using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
    
    public IActionResult Index() {
    return Ok("This is the index of the HomeController"); }
 
    public IActionResult Quote(){
    return Ok("Quote section of HomeConroller");
    }
}