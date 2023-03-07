using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversidadCRUD.Models;

public class Alumno
{
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 6)]
    [Required]
    public string? Nombre { get; set; }
    
    [Required]
    public int Matrícula { get; set; }
    [Required]
    [StringLength(60)]

    public string? Carrera { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Grupo { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(30)]
    public string? Ciclo { get; set; } = string.Empty;
}