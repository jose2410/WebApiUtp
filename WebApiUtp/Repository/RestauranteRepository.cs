using Microsoft.EntityFrameworkCore;
using WebApiUtp.Data;
using WebApiUtp.Models;

namespace WebApiUtp.Repository
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private readonly RestauranteDbContext _context;

        public RestauranteRepository(RestauranteDbContext context)
        {
            _context = context;
        }

        public async Task<Restaurante> RegistrarRestaurante(Restaurante restaurante)
        {
            _context.restaurantes.Add(restaurante);
            await _context.SaveChangesAsync();
            return restaurante;
        }
        public async Task<Restaurante> ObtenerRestaurante(int id)
        {
            return await _context.restaurantes.FindAsync(id);
        }
        //public async Task<Restaurante> GetRestauranteByEmailAndPassword(string correo, string contrasena)
        //{
        //    // Buscar al usuario por correo y contraseña en la base de datos
        //    return await _context.restaurantes.FirstOrDefaultAsync(r => r.correo == correo && r.contrasena == contrasena);
        //}

    }
}
