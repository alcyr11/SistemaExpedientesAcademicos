using System;
using System.Collections.Generic;

namespace SistemaExpedientesAcademicos.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Grado { get; set; }

        // aquí guardo todos los expedientes que tiene este alumno
        public List<Expediente> Expedientes { get; set; }
    }
}