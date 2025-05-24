using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;

namespace PeliculasAPIs.Entidades
{
    public class Cine: IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(75)]
        public required string Nombre { get; set; }
        public required Point Ubicacion { get; set; }
    }
}
