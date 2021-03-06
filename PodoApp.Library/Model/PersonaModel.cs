﻿using System;
using System.Collections.Generic;

namespace PodoApp.Library.Model
{
    public class PersonaModel
    {
        public Guid idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public int? edad { get; set; }
        public string profesion { get; set; }
        public string calle { get; set; }
        public string ciudad { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }        
        public ICollection<PacienteModel> paciente { get; set; }   
        public ICollection<PodologoModel> podologo { get; set; }
    }
}