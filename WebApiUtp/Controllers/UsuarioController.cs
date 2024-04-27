using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiUtp.Models;
using WebApiUtp.Repository;

namespace WebApiUtp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> RegistrarUsuario(Usuario usuario)
        {
            var nuevoUsuario = await _usuarioRepository.RegistrarUsuario(usuario);
            return CreatedAtAction(nameof(ObtenerUsuario), new { id = nuevoUsuario.id }, nuevoUsuario);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> ObtenerUsuario(int id)
        {
            var usuario = await _usuarioRepository.ObtenerUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }

    }
}
