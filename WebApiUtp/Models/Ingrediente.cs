﻿namespace WebApiUtp.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public int ComidaId { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public Comida Comida { get; set; }
    }
}
