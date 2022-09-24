using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ProyectoFinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Materia_primaController : ControllerBase
    {
        Materia_primaLogic materia_PrimaLogic = new Materia_primaLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<Materia_primaModel> listaResultados = new List<Materia_primaModel>();
            listaResultados = await materia_PrimaLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            Materia_primaModel resultado = new Materia_primaModel();
            resultado = await materia_PrimaLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(Materia_primaModel request)
        {
            Materia_primaModel response = await materia_PrimaLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] Materia_primaModel request)
        {
            Materia_primaModel response = await materia_PrimaLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await materia_PrimaLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
