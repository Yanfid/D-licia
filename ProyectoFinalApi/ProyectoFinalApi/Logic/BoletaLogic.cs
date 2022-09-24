using Logic.Interface;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BoletaLogic : ICRUDLogica<BoletaModel>
    {
        BoletaRepository repo = new BoletaRepository();
        public async Task<BoletaModel> ActualizarRegistro(BoletaModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<BoletaModel> CrearRegistro(BoletaModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<BoletaModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<BoletaModel>> ListarTodo()
        {
            List<BoletaModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<BoletaModel> ObtenerPorId(int id)
        {
            BoletaModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
