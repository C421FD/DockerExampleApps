using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    // GET api/values
    [HttpGet]
    public async Task<string> Get()
    {
      using (var httpClient = new HttpClient())
      {
        var result = await httpClient.GetAsync("http://172.17.0.11:22000/api/values");
        return await result.Content.ReadAsStringAsync();
      }
    }
  }
}