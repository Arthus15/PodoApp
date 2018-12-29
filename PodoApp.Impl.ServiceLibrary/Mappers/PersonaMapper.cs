using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class PersonaMapper
    {
        public static PersonaDto ModelToDto(this PersonaModel persona)
        {
            return new PersonaDto
            {
                idPersona = persona.idPersona,
                nombre = persona.nombre,
                apellido1 = persona.apellido1,
                apellido2 = persona.apellido2,
                calle = persona.calle,
                ciudad = persona.ciudad,
                dni = persona.dni,
                edad = persona.edad,
                telefono = persona.telefono,
                profesion = persona.profesion,
                pais = persona.pais,
                fechaNacimiento = persona.fechaNacimiento,
                provincia = persona.provincia
            };
        }

        public static PersonaModel DtoToModel(this PersonaDto persona)
        {
            return new PersonaModel
            {
                idPersona = persona.idPersona,
                nombre = persona.nombre,
                apellido1 = persona.apellido1,
                apellido2 = persona.apellido2,
                calle = persona.calle,
                ciudad = persona.ciudad,
                dni = persona.dni,
                edad = persona.edad,
                telefono = persona.telefono,
                profesion = persona.profesion,
                pais = persona.pais,
                fechaNacimiento = persona.fechaNacimiento,
                provincia = persona.provincia
            };
        }
    }
}
