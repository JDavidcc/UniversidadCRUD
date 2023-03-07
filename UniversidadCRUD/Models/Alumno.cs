﻿using System.ComponentModel.DataAnnotations;

namespace UniversidadCRUD.Models;

public class Alumno
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    
    public int Matrícula { get; set; }
    public string? Carrera { get; set; }
    public string? Grupo { get; set; }
}