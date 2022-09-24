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
    public class Materia_primaRepository: ICRUD<Materia_primaModel>
    {
        _dbContext db = new _dbContext();

        public async Task<Materia_primaModel> ActualizarRegistro(Materia_primaModel input)
        {
            db.materia_Primas.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Materia_primaModel> CrearRegistro(Materia_primaModel input)
        {
            await db.materia_Primas.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Materia_primaModel> EliminarRegistro(int id)
        {
            var xd = await db.materia_Primas.FindAsync(id);
            db.materia_Primas.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<Materia_primaModel>> ListarTodo()
        {
            List<Materia_primaModel> lista = await db.materia_Primas
                                         .Include(z => z.Uni_Medida)
                                         .Include(z => z.Empleado)
                                         .ToListAsync();
            return lista;
        }

        public async Task<Materia_primaModel> ObtenerPorId(int id)
        {
            Materia_primaModel cargo = await db.materia_Primas.FindAsync(id);
            return cargo;
        }
    }
}
