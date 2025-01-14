using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : Controller
{
    [HttpGet]
    public string Get() => "Hello world test!";

    [HttpGet("{id:int:min(10)}")] // /HelloWorld/10/HelloWorld/10
    public IActionResult GetById(int id) {
        return  Ok(new { message = "Hello world! " + id.ToString()});
    }

    [HttpGet("param")]  //  /HelloWorld/param?id=50&rg=12345
    public IActionResult GetFromParam([FromQuery] int id, int rg=5) {
        return Ok(new { message = string.Format("Id is: {0} and Rg is: {1}", id, rg)});
    }
}
