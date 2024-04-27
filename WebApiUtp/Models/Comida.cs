namespace WebApiUtp.Models
{
    public class Comida
    {
        public int Id { get; set; }
        public int RestauranteId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
