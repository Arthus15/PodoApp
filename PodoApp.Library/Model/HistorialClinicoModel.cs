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
        public virtual AntecedentesFamiliaresModel antecedentesFamiliares { get; set; }
        public virtual AntecedentesFisiologicosModel antecedentesFisiologicos { get; set; }
        public virtual AntecedentesPatologicosModel antecedentesPatologicos { get; set; }
        public virtual AntecedentesPodologicosModel antecedentesPodologicos { get; set; }
        public virtual ICollection<PacienteModel> paciente { get; set; }
    }
}