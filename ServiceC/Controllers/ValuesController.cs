using Microsoft.AspNetCore.Mvc;

namespace ServiceC.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    // GET api/values
    [HttpGet]
    public string Get()
    {
      return "Hello from Service C!";
    }
  }
}