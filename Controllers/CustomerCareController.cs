using Microsoft.AspNetCore.Mvc;

[Route("customer")]
[Route("claim")]
public class CustomerCareController : Controller {
    
    public IActionResult index(){
        return Ok("Customer Care Index");
    }

    public IActionResult Claims(){
     return Quote();
    }

    public IActionResult Quote(){
        return Ok("Quote in CustomerCareController");
    }

    [Route("fileclaim")]
    public IActionResult NewClaim(){
        return Ok("claim filed");
    }

    [Route("claimstatus")]
    [Route("myclaims")]
    public IActionResult ClaimHistory(){
        return Ok("claim history");
    }
}