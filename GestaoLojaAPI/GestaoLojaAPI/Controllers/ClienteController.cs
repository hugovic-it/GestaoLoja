using GestaoLojaAPI.Context;
using GestaoLojaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLojaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly AppDbContext _context;

    [HttpGet] //Get ALL
    public ActionResult<IEnumerable<Cliente>> Get()
    {
        var clientes = _context.Clientes.ToList();
        return Ok(clientes);
    }
}
