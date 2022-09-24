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
    public  class VentaLogic:ICRUDLogica<VentaModel>
    {
        VentaRepository repo = new VentaRepository();

        public async Task<VentaModel> ActualizarRegistro(VentaModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<VentaModel> CrearRegistro(VentaModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<VentaModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<VentaModel>> ListarTodo()
        {
            List<VentaModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<VentaModel> ObtenerPorId(int id)
        {
            VentaModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
