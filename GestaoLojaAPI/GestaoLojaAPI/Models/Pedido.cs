using System.ComponentModel.DataAnnotations;

namespace GestaoLojaAPI.Models;

public class Pedido
{
    [Key]
    public int PedidoId { get; set; }
    [Required]
    public Cliente? Cliente { get; set; } //necessita estar associado a um objeto Cliente.
    public List<Produto> Produtos { get; set; } = new List<Produto>(); //Lista de produtos
    [Required]
    public DateTime DataPedido { get; set; }
}
