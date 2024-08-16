using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestaoLojaAPI.Models;


[Table("Clientes")]
public class Cliente
{
    [Key]
    public int ClienteId { get; set; }
    [StringLength(60)]
    public string? Nome { get; set; }
    [StringLength(60)]
    public string? Apelido { get; set; }
    [DataType(DataType.Date)]
    public DateTime Nascimento { get; set; }
    [Range(1, 999999999999)]
    public long Telefone { get; set; }
    [Range(1, 99999999)]
    public int Cep { get; set; }
    [StringLength(40)]
    public string? Cidade { get; set; }
    [StringLength(40)]
    public string? Bairro { get; set; }
    [StringLength(80)]
    public string? Rua { get; set; }
    [StringLength(80)]
    public string? NumeroResidencia { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>(); //Lista de Pedidos //armazena os objetos
    public bool EstaDevendo { get; set; }
    [Range(0.00, 99999.99)]
    public decimal ValorDivida { get; set; }
    [StringLength(300)]
    public string? Observacao { get; set; }


}
