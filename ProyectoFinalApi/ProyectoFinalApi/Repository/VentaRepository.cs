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
    public class VentaRepository:ICRUD<VentaModel>
    {
        _dbContext db = new _dbContext();

        public async Task<VentaModel> ActualizarRegistro(VentaModel input)
        {
            db.ventas.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<VentaModel> CrearRegistro(VentaModel input)
        {
            await db.ventas.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<VentaModel> EliminarRegistro(int id)
        {
            var xd = await db.ventas.FindAsync(id);
            db.ventas.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<VentaModel>> ListarTodo()
        {
            List<VentaModel> lista = await db.ventas
                                         .Include(z => z.Pedido)
                                         .ToListAsync();
            return lista;
        }

        public async Task<VentaModel> ObtenerPorId(int id)
        {
            VentaModel pedido = await db.ventas.FindAsync(id);
            return pedido;
        }
    }
}
