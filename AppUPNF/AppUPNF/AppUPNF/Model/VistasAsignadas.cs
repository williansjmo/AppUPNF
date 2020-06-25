using System;
using System.Collections.Generic;
using System.Text;

namespace AppUPNF.Model
{
    public class VistasAsignadas
    {
        public int VisitasAsignadasId { get; set; }
        public string TipoIdentificacion { get; set; }
        public double NIdentificacion { get; set; }
        public double NSolicitud { get; set; }
        public string Solicitante { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public string NombreUnidadNegocio { get; set; }
        public string DireccionUnidadNegocio { get; set; }
        public string Barrio { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string OficinaRadiacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string UserId { get; set; }
    }
}
