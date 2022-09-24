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
    public class Uni_MedidaRepository : ICRUD<Uni_MedidaModel>
    {
        _dbContext db = new _dbContext();
        public async Task<Uni_MedidaModel> ActualizarRegistro(Uni_MedidaModel input)
        {
            db.uni_Medidas.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Uni_MedidaModel> CrearRegistro(Uni_MedidaModel input)
        {
            await db.uni_Medidas.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Uni_MedidaModel> EliminarRegistro(int id)
        {
            var xd = await db.uni_Medidas.FindAsync(id);
            db.uni_Medidas.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<Uni_MedidaModel>> ListarTodo()
        {
            List<Uni_MedidaModel> lista = await db.uni_Medidas.ToListAsync();
            return lista;
        }

        public async Task<Uni_MedidaModel> ObtenerPorId(int id)
        {
            Uni_MedidaModel medida = await db.uni_Medidas.FindAsync(id);
            return medida;
        }
    }
}
