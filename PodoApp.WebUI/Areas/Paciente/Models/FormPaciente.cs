using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Paciente.Models
{
    public class FormPaciente : IEnumerable
    {
        [Key()]
        IEnumerable<FormPaciente> pacientes { get; set; }

        // PACIENTE

        [Required()]
        public Guid IdPaciente { get; set; }

        [DisplayName("Medicación habitual")]
        [Required()]
        public string MedicacionHabitual { get; set; }

        [DisplayName("Observación")]
        public string Observacion { get; set; }

        [DisplayName("Número Historia Clínica")]
        [Required()]
        public string NumeroHistoriaClinica { get; set; }

        [DisplayName("Podólogo que realiza la consulta")]
        public Guid? IdPodologo { get; set; }

        // PERSONA
        [DisplayName("Nombre")]
        [Required()]
        public string Nombre { get; set; }

        [DisplayName("Primer apellido")]
        [Required()]
        public string PrimerApellido { get; set; }

        [DisplayName("Segundo apellido")]
        public string SegundoApellido { get; set; }

        [DisplayName("Fecha nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Required()]
        public DateTime? FechaNacimiento { get; set; }

        [DisplayName("Edad")]
        [Required()]
        public int? Edad { get; set; }

        [DisplayName("Profesión")]
        public string Profesion { get; set; }

        [DisplayName("Dirección")]
        [Required()]
        public string Direccion { get; set; }

        [DisplayName("Ciudad")]
        [Required()]
        public string Ciudad { get; set; }

        [DisplayName("Provincia")]
        public string Provincia { get; set; }

        [DisplayName("País")]
        [Required()]
        public string Pais { get; set; }

        [DisplayName("Teléfono")]
        [Required()]
        [MaxLength(9, ErrorMessage = "El número de teléfono debe estar formado por 9 dígitos")]
        [MinLength(9, ErrorMessage = "El número de teléfono debe estar formado por 9 dígitos")]
        public string Telefono { get; set; }

        [DisplayName("DNI")]
        [Required()]
        [RegularExpression(@"^((([A-Z]|[a-z])\d{8})|(\d{8}([A-Z]|[a-z])))$", ErrorMessage = "Introduzca un DNI válido")]
        public string Dni { get; set; }


        // Enumerator

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)pacientes).GetEnumerator();
        }


    }
}