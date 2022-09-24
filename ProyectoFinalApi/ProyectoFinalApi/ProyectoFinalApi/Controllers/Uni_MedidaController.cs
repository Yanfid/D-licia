using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProyectoFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Uni_MedidaController : ControllerBase
    {
        Uni_MedidaLogic uni_MedidaLogic = new Uni_MedidaLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<Uni_MedidaModel> listaResultados = new List<Uni_MedidaModel>();
            listaResultados = await uni_MedidaLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            Uni_MedidaModel resultado = new Uni_MedidaModel();
            resultado = await uni_MedidaLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(Uni_MedidaModel request)
        {
            Uni_MedidaModel response = await uni_MedidaLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] Uni_MedidaModel request)
        {
            Uni_MedidaModel response = await uni_MedidaLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await uni_MedidaLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
