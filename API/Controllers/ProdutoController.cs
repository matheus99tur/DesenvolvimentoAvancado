using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]
[Route("api/produto")]

public class ProdutoController : ControllerBase 
{
    // Exemplo de método dentro de uma classe

    [HttpGet]
    public string Metodo()
    {
        return "";
    }

    //Exemplo de u EndPoit dentro de um Controller
    [HttpGet("Helloword")]
    public IActionResult HelloWorld()
    {
        return Ok("Hello world");
    }
}
