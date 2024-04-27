using WebApiUtp.Models;

namespace WebApiUtp.Repository
{
    public interface IRestauranteRepository
    {
        Task<Restaurante> RegistrarRestaurante(Restaurante restaurante);
        Task<Restaurante> ObtenerRestaurante(int id);
        //Task<Restaurante> GetRestauranteByEmailAndPassword(string correo, string contrasena);
    }
}
