using System;
using System.Collections.Generic;

namespace PodoApp.Library.Model
{
    public class HistorialClinicoModel
    {
        public System.Guid idHistorialClinico { get; set; }
        public string numeroHistorialClinico { get; set; }
        public Guid? id_ant_podologicos { get; set; }
        public Guid? id_ant_patologicos { get; set; }
        public Guid? id_ant_fisiologicos { get; set; }
        public Guid? id_ant_familiares { get; set; }
        public Guid? id_estudio { get; set; }
        public AntecedentesFamiliaresModel antecedentesFamiliares { get; set; }
        public AntecedentesFisiologicosModel antecedentesFisiologicos { get; set; }
        public AntecedentesPatologicosModel antecedentesPatologicos { get; set; }
        public AntecedentesPodologicosModel antecedentesPodologicos { get; set; }
    }
}