using PeliculasAPIs.Entidades;

namespace PeliculasAPIs.DTOs
{
    public class GeneroDTO : IId
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
    }
}
