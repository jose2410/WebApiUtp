namespace WebApiUtp.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RestauranteId { get; set; }
        public int MesaId { get; set; }
        public DateTime FechaHora { get; set; }
        public string EstadoReserva { get; set; }
        public Usuario Usuario { get; set; }
        public Restaurante Restaurante { get; set; }
        public Mesa Mesa { get; set; }
    }
}
