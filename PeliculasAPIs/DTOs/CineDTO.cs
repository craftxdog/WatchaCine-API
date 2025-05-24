using PeliculasAPIs.Entidades;

namespace PeliculasAPIs.DTOs
{
    public class CineDTO: IId
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
