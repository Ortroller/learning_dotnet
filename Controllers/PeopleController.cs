using Microsoft.AspNetCore.Mvc;
using csharpback.Models;
using csharpback;


namespace csharpback.Controllers;

[ApiController]
[Route("Pessoa")]
public class PeopleController : ControllerBase{

    private List<people> storage = runtime_storage.cad;

    [HttpGet]
    public List<people> Get(){
        return runtime_storage.cad;
    }
    
    [HttpPost]
    public ActionResult Post([FromBody] people user){
        
        people obj = user;
        storage.Add(obj);

        Response.Headers.Add("server_status" , "Online"); // Enviando um header

        string count = storage.Count.ToString();
        return Ok("name : " + obj.name);
    }
}

