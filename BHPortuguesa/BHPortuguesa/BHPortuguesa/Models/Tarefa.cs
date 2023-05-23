namespace BHPortuguesa.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tarefa
{
    [Key]
    public int IDTarefa { get; set; }

    [Required]
    [StringLength(75)]
    public string NomeTarefa { get; set; }

    [Required]
    public DateTime DataTarefa { get; set; }

    [Required]
    [ForeignKey(nameof(Empregado))]
    public int EmpregadoID { get; set; }
    public Empregado Empregado { get; set; }
}

