using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class CalzadoHabitualMapper
    {
        public static CalzadoHabitualModel EntityToModel(this CalzadoHabitual calzadoHabitual)
        {
            return new CalzadoHabitualModel
            {
                idCalzado = calzadoHabitual.idCalzado,
                deportivos = calzadoHabitual.deportivos,
                sandalias = calzadoHabitual.sandalias,
                botines = calzadoHabitual.botines,
                tacones = calzadoHabitual.tacones,
                vestir = calzadoHabitual.vestir
            };
        }

        public static CalzadoHabitual ModelToEntity(this CalzadoHabitualModel calzadoHabitual)
        {
            return new CalzadoHabitual
            {
                idCalzado = calzadoHabitual.idCalzado,
                deportivos = calzadoHabitual.deportivos,
                sandalias = calzadoHabitual.sandalias,
                botines = calzadoHabitual.botines,
                tacones = calzadoHabitual.tacones,
                vestir = calzadoHabitual.vestir
            };
        }

        public static void MapChanges(this CalzadoHabitual newCalzadoHabitual, ref CalzadoHabitual oldCalzadoHabitual)
        {
            oldCalzadoHabitual.deportivos = newCalzadoHabitual.deportivos;
            oldCalzadoHabitual.sandalias = newCalzadoHabitual.sandalias;
            oldCalzadoHabitual.botines = newCalzadoHabitual.botines;
            oldCalzadoHabitual.tacones = newCalzadoHabitual.tacones;
            oldCalzadoHabitual.vestir = newCalzadoHabitual.vestir;
        }
    }
}
