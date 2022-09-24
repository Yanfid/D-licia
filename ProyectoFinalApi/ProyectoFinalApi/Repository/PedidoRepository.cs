using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PedidoRepository : ICRUD<PedidoModel>
    {
        _dbContext db = new _dbContext();
        public async Task<PedidoModel> ActualizarRegistro(PedidoModel input)
        {
            db.pedidos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PedidoModel> CrearRegistro(PedidoModel input)
        {
            await db.pedidos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PedidoModel> EliminarRegistro(int id)
        {
            var xd = await db.pedidos.FindAsync(id);
            db.pedidos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<PedidoModel>> ListarTodo()
        {
            List<PedidoModel> lista = await db.pedidos
                                         .Include(z => z.Productos)
                                         .ToListAsync();
            return lista;
        }

        public async Task<PedidoModel> ObtenerPorId(int id)
        {
            PedidoModel pedido = await db.pedidos.FindAsync(id);
            return pedido;
        }
    }
}
