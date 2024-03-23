using System;
using System.Collections.Generic;

namespace PracticaMVC1.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Contrasenia { get; set; }

    public string? Genero { get; set; }

    public string? Direccion { get; set; }

    public string? Pasatiempos { get; set; }

    public string? Curso { get; set; }

    public string? Conocimientos { get; set; }
}
