namespace BHPortuguesa.Models;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int IDCliente { get; set; }

    [Required]
    [StringLength(75)]
    public string NomeCliente { get; set; }

    [Required]
    [StringLength(255)]
    public string Morada { get; set; }

    [Required]
    [StringLength(75)]
    public string Cidade { get; set; }

    [Required]
    [StringLength(25)]
    public string CodPostal { get; set; }

    [Required]
    [StringLength(50)]
    public string País { get; set; }

    [StringLength(20)]
    public string Telefone { get; set; }

    [StringLength(20)]
    public string Telemovel { get; set; }

    [StringLength(100)]
    public string Email { get; set; }
}
