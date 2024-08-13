using GestaoLojaAPI.Context;
using GestaoLojaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLojaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly AppDbContext _context;
    public PedidoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet] //Get ALL
    public ActionResult<IEnumerable<Pedido>> Get()
    {
        var pedidos = _context.Clientes.ToList();
        return Ok(pedidos);
    }
}