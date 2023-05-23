namespace BHPortuguesa.Models;
using System.ComponentModel.DataAnnotations;

public class Empregado
{
    [Key]
    public int IDEmpregado { get; set; }

    [Required]
    [StringLength(75)]
    public string NomeEmpregado { get; set; }
}


