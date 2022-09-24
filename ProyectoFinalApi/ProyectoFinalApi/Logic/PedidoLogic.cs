using Logic.Interface;
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
    public class PedidoLogic : ICRUDLogica<PedidoModel>
    {
        PedidoRepository repo = new PedidoRepository();
        public async Task<PedidoModel> ActualizarRegistro(PedidoModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<PedidoModel> CrearRegistro(PedidoModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<PedidoModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<PedidoModel>> ListarTodo()
        {
            List<PedidoModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<PedidoModel> ObtenerPorId(int id)
        {
            PedidoModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
