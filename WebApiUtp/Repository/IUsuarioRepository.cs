using WebApiUtp.Models;

namespace WebApiUtp.Repository
{
    public interface IUsuarioRepository
    {
        Task<Usuario> RegistrarUsuario(Usuario usuario);
        Task<Usuario> ObtenerUsuario(int id);

        Task<Usuario> GetUsuarioByEmailAndPassword(string correo, string contrasena);

    }
}
