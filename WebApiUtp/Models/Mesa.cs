namespace WebApiUtp.Models
{
    public class Mesa
    {
        public int Id { get; set; }
        public int RestauranteId { get; set; }
        public int NumeroMesa { get; set; }
        public int NumeroAsientos { get; set; }
        public bool Disponibilidad { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
