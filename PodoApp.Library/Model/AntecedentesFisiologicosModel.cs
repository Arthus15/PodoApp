﻿using System;

namespace PodoApp.Library.Model
{
    public class AntecedentesFisiologicosModel
    {
        public Guid idAFisiologico { get; set; }

        public bool andador { get; set; }

        public bool tacata { get; set; }

        public int? inicioDeambulacion { get; set; }

        public string habitosPosturales { get; set; }

        public int? cambiosPonderales { get; set; }

        public bool zurdo { get; set; }

        public bool diestro { get; set; }

        public bool ambidiestro { get; set; }

        public string otros { get; set; }

        public bool partoCabeza { get; set; }

        public bool partoNalgas { get; set; }
    }
}