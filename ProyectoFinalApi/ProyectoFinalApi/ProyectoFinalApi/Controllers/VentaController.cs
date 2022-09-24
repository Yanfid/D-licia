using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProyectoFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        VentaLogic ventaLogic = new VentaLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<VentaModel> listaResultados = new List<VentaModel>();
            listaResultados = await ventaLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            VentaModel resultado = new VentaModel();
            resultado = await ventaLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(VentaModel request)
        {
            VentaModel response = await ventaLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] VentaModel request)
        {
            VentaModel response = await ventaLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await ventaLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
