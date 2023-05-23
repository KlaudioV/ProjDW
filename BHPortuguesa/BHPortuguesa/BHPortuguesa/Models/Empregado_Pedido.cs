namespace BHPortuguesa.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Empregado_Pedido
{
    [Key]
    [Column(Order = 0)]
    [ForeignKey(nameof(Pedido))]
    public int IDPedidoFK { get; set; }
    public Pedido Pedido { get; set; }

    [Key]
    [Column(Order = 1)]
    [ForeignKey(nameof(Empregado))]
    public int IDEmpregadoFK { get; set; }
    public Empregado Empregado { get; set; }
}


