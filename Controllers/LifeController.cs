using Microsoft.AspNetCore.Mvc;

public class LifeController : Controller {

    public IActionResult Index(){
        return Ok("Life Controller Area");
    }

    public IActionResult Quote(){
        return Ok("Life Controller Quote Section");
    }
}