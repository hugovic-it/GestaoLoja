using GestaoLojaAPI.Context;
using GestaoLojaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLojaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProdutoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet] //Get ALL
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var produtos = _context.Clientes.ToList();
        return Ok(produtos);
    }
    [HttpPost] // POST Clientes
    public async Task<ActionResult<Cliente>> Post()
    {

        var produtos = new List<Produto>
            {
                //Inserir Lista Inicial dos Produtos
            };

        _context.Produtos.AddRange(produtos);
        await _context.SaveChangesAsync();

        return Ok($"{produtos.Count} clientes foram adicionados com sucesso.");
    }
}
