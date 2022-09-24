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
    public class BoletaRepository:ICRUD<BoletaModel>
    {
        _dbContext db = new _dbContext();

        public async Task<BoletaModel> ActualizarRegistro(BoletaModel input)
        {
            db.boletas.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<BoletaModel> CrearRegistro(BoletaModel input)
        {
            await db.boletas.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<BoletaModel> EliminarRegistro(int id)
        {
            var xd = await db.boletas.FindAsync(id);
            db.boletas.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<BoletaModel>> ListarTodo()
        {
            List<BoletaModel> lista = await db.boletas
                                         .Include(z => z.Venta)
                                         .ToListAsync();
            return lista;
        }

        public async Task<BoletaModel> ObtenerPorId(int id)
        {
            BoletaModel pedido = await db.boletas.FindAsync(id);
            return pedido;
        }
    }
}
