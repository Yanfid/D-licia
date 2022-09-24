using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProyectoFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        PedidoLogic pedidoLogic = new PedidoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<PedidoModel> listaResultados = new List<PedidoModel>();
            listaResultados = await pedidoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            PedidoModel resultado = new PedidoModel();
            resultado = await pedidoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(PedidoModel request)
        {
            PedidoModel response = await pedidoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] PedidoModel request)
        {
            PedidoModel response = await pedidoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await pedidoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
