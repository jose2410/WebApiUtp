namespace WebApiUtp.Models
{
    public class Restaurantefavorito
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RestauranteId { get; set; }
        public Usuario Usuario { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
