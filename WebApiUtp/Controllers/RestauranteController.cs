using Microsoft.AspNetCore.Mvc;
using WebApiUtp.Models;
using WebApiUtp.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiUtp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestauranteController : ControllerBase
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteController(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Restaurante>> RegistrarRestaurante(Restaurante restaurante)
        {
            var nuevoRestaurante = await _restauranteRepository.RegistrarRestaurante(restaurante);
            return CreatedAtAction(nameof(ObtenerRestaurante), new { id = nuevoRestaurante.id }, nuevoRestaurante);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurante>> ObtenerRestaurante(int id)
        {
            var restaurante = await _restauranteRepository.ObtenerRestaurante(id);
            if (restaurante == null)
            {
                return NotFound();
            }
            return restaurante;
        }

    }
}
