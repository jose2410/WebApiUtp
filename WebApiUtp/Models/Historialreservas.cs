namespace WebApiUtp.Models
{
    public class Historialreservas
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RestauranteId { get; set; }
        public DateTime FechaReserva { get; set; }
        public string EstadoReserva { get; set; } = "Pendiente";
        public Usuario Usuario { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
