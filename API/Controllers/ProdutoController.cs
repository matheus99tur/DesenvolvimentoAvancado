using System;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]
[Route("api/produto")]

public class ProdutoController : ControllerBase 
{
    private readonly IProdutoRepository _produtoRepository;
    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Produto produto)
    {
        _produtoRepository.Cadastrar(produto);
        return Created("", produto);
    }
}
