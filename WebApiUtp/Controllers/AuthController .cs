using Microsoft.AspNetCore.Mvc;
using WebApiUtp.Models;
using WebApiUtp.Repository;

namespace WebApiUtp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IRestauranteRepository _restauranteRepository;



        public AuthController(IUsuarioRepository usuarioRepository, IRestauranteRepository restauranteRepository)
        {
            _usuarioRepository = usuarioRepository;
            _restauranteRepository = restauranteRepository;
        }

        [HttpPost("loginU")]
        public async Task<IActionResult> LoginUsuario([FromBody] Auth a)
        {
            // Verificar si el usuario existe en la base de datos
            var usuario = await _usuarioRepository.GetUsuarioByEmailAndPassword(a.correo, a.contrasena);

            if (usuario == null)
            {
                return Unauthorized(); // Devolver un error 401 Unauthorized si las credenciales son incorrectas
            }

            // Si el usuario existe y las credenciales son correctas, puedes retornar cualquier información adicional necesaria
            return Ok(new { usuario.id, usuario.nombre, usuario.correo });
        }

        //[HttpPost("loginR")]
        //public async Task<IActionResult> LoginRestaurante([FromBody] Auth a)
        //{
        //    // Verificar si el usuario existe en la base de datos
        //    var restaurante = await _restauranteRepository.GetRestauranteByEmailAndPassword(a.correo, a.contrasena);

        //    if (restaurante == null)
        //    {
        //        return Unauthorized(); // Devolver un error 401 Unauthorized si las credenciales son incorrectas
        //    }

        //    // Si el usuario existe y las credenciales son correctas, puedes retornar cualquier información adicional necesaria
        //    //return Ok(new { restaurante.id, restaurante.nombre_restaurante, restaurante.correo });
        //    return Ok(new { restaurante.id, restaurante.nombre_restaurante });
        //}
    }
}
