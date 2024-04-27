using Microsoft.EntityFrameworkCore;
using WebApiUtp.Data;
using WebApiUtp.Models;

namespace WebApiUtp.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RestauranteDbContext _context;

        public UsuarioRepository(RestauranteDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> RegistrarUsuario(Usuario usuario)
        {
            _context.usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
        public async Task<Usuario> ObtenerUsuario(int id)
        {
            return await _context.usuarios.FindAsync(id);
        }

        public async Task<Usuario> GetUsuarioByEmailAndPassword(string correo, string contrasena)
        {
            // Buscar al usuario por correo y contraseña en la base de datos
            return await _context.usuarios.FirstOrDefaultAsync(u => u.correo == correo && u.contrasena == contrasena);
        }

    }
}
