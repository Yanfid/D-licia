using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProyectoFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoletaController : ControllerBase
    {
        BoletaLogic boletaLogic = new BoletaLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<BoletaModel> listaResultados = new List<BoletaModel>();
            listaResultados = await boletaLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            BoletaModel resultado = new BoletaModel();
            resultado = await boletaLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(BoletaModel request)
        {
            BoletaModel response = await boletaLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] BoletaModel request)
        {
            BoletaModel response = await boletaLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await boletaLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
