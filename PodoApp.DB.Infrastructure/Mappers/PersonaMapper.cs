using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class PersonaMapper
    {
        public static PersonaModel EntityToModel(this Persona persona)
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
                profesion = persona.provincia,
                pais = persona.pais,
                fechaNacimiento = persona.fechaNacimiento
            };
        }

        public static Persona ModelToEntity(this PersonaModel persona)
        {
            return new Persona
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
                profesion = persona.provincia,
                pais = persona.pais,
                fechaNacimiento = persona.fechaNacimiento
            };
        }
    }
}
