using GestaoLojaAPI.Context;
using GestaoLojaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLojaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly AppDbContext _context;
    public ClienteController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet] //Get ALL
    public ActionResult<IEnumerable<Cliente>> Get()
    {
        var clientes = _context.Clientes.ToList();
        return Ok(clientes);
    }

    [HttpPost] // POST Clientes
    public async Task<ActionResult<Cliente>> Post()
    {

        var clientes = new List<Cliente>
            {
                //Inserir Lista Inicial dos Clientes
            };

        _context.Clientes.AddRange(clientes);
        await _context.SaveChangesAsync();

        return Ok($"{clientes.Count} clientes foram adicionados com sucesso.");
    }

}
