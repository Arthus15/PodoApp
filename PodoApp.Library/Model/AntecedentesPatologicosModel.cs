﻿using System;

namespace PodoApp.Library.Model
{
    public class AntecedentesPatologicosModel
    {
        public Guid idAPatologico { get; set; }

        public string patologiaPrevia { get; set; }

        public string enfermedadInfantil { get; set; }

        public string antecedentesTraumatico { get; set; }

        public bool bursitis { get; set; }

        public bool capsulitis { get; set; }

        public bool enfermedadReumatica { get; set; }

        public string tipoEnfermedadReumatica { get; set; }

        public bool ciatica { get; set; }

        public string otros { get; set; }

        public bool distension { get; set; }

        public bool esguince { get; set; }

        public bool tendinitis { get; set; }

        public bool contracturas { get; set; }

        public bool luxacion { get; set; }

        public bool subluxacion { get; set; }

        public bool fisura { get; set; }

        public bool fractura { get; set; }
    }
}