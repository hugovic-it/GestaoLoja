using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestaoLojaAPI.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }
    [StringLength(60)]
    public string? Nome { get; set; }
    [StringLength(20)]
    public string? Tipo { get; set; }
    [StringLength(10)]
    public string? Genero { get; set; }
    [Range(0, 16)] //16 anos ?  //Tamanho
    public int Idade { get; set; }
    [Range(0.00, 999.99)]
    public decimal ValorAtacado { get; set; }
    [Range(0.00, 999.99)]
    public decimal ValorFinal { get; set; }
    [StringLength(10)]
    public string? Status { get; set; }  //disponivel, vendido...
    [StringLength(100)]
    public string? ImagemUrl { get; set; }
    [StringLength(300)]
    public string? Observacao { get; set; }

}