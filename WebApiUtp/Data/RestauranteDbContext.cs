using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebApiUtp.Models;

namespace WebApiUtp.Data
{
    public class RestauranteDbContext : DbContext
    {
        public RestauranteDbContext(DbContextOptions<RestauranteDbContext> options) : base(options) { }

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Restaurante> restaurantes { get; set; }
        public DbSet<Mesa> mesas { get; set; }
        public DbSet<Reserva> reservas { get; set; }
        public DbSet<Restaurantefavorito> restaurantesfavoritos { get; set; }
        public DbSet<Comida> comidas { get; set; }
        public DbSet<Ingrediente> ingredientes { get; set; }
        public DbSet<Historialreservas> historialesreservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
