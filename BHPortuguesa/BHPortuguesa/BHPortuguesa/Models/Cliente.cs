using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int IDCliente { get; set; }

    [Required]
    [StringLength(75)]
    public string NomeCliente { get; set; }

    [StringLength(255)]
    [Required]
    public string Morada { get; set; }

    [StringLength(75)]
    [Required]
    public string Cidade { get; set; }

    [StringLength(25)]
    [Required]
    public string CodPostal { get; set; }

    [StringLength(50)]
    [Required]
    public string País { get; set; }

    [StringLength(20)] // Adjust the length as needed
    public string? Telefone { get; set; }

    [StringLength(20)] // Adjust the length as needed
    public string? Telemovel { get; set; }

    [EmailAddress]
    [StringLength(100)] // Adjust the length as needed
    public string? Email { get; set; }
}
