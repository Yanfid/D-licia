using Models;
using Repository;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Materia_primaLogic : ICRUD<Materia_primaModel>
    {
        Materia_primaRepository repo = new Materia_primaRepository();

        public async Task<Materia_primaModel> ActualizarRegistro(Materia_primaModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<Materia_primaModel> CrearRegistro(Materia_primaModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<Materia_primaModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<Materia_primaModel>> ListarTodo()
        {
            List<Materia_primaModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<Materia_primaModel> ObtenerPorId(int id)
        {
            Materia_primaModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
