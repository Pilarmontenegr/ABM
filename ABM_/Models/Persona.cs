using System;
using System.Collections.Generic;

namespace ABM_.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dni { get; set; }
        public string? Domicilio { get; set; }
        public int Edad { get; set; }
    }
}
