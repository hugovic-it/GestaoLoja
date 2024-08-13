using System.ComponentModel.DataAnnotations;

namespace GestaoLojaAPI.Models;

public class Pedido
{
    [Key]
    public int PedidoId { get; set; }
    [Required]
    public int ClienteId { get; set; } //necessita estar associado a um objeto Cliente.
    public List<int> ProdutoIds  { get; set; } = new List<int>(); // Armazena apenas os IDs dos Produtos
    //public List<Produto> Produtos { get; set; } = new List<Produto>(); //Lista de produtos
    [Required]
    public DateTime DataPedido { get; set; }
    [StringLength(20)]
    public string? Status { get; set; }
    [StringLength(300)]
    public string? Observacao { get; set; }
}
