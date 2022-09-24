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
    public class Uni_MedidaLogic:ICRUDLogica<Uni_MedidaModel>
    {
        Uni_MedidaRepository repo = new Uni_MedidaRepository();

        public async Task<Uni_MedidaModel> ActualizarRegistro(Uni_MedidaModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<Uni_MedidaModel> CrearRegistro(Uni_MedidaModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<Uni_MedidaModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<Uni_MedidaModel>> ListarTodo()
        {
            List<Uni_MedidaModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<Uni_MedidaModel> ObtenerPorId(int id)
        {
            Uni_MedidaModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
