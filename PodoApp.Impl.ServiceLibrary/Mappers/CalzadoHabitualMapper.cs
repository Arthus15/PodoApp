using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodoApp.Contracts.ServiceLibrary.Dto;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class CalzadoHabitualMapper
    {
        public static CalzadoHabitualDto ModelToDto(this CalzadoHabitualModel calzadoHabitual)
        {
            return new CalzadoHabitualDto
            {
                idCalzado = calzadoHabitual.idCalzado,
                deportivos = calzadoHabitual.deportivos,
                sandalias = calzadoHabitual.sandalias,
                botines = calzadoHabitual.botines,
                tacones = calzadoHabitual.tacones,
                vestir = calzadoHabitual.vestir
            };
        }

        public static CalzadoHabitualModel DtoToModel(this CalzadoHabitualDto calzadoHabitual)
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
    }
}
