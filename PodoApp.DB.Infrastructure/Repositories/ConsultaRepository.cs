using PodoApp.DB.Infrastructure.Abstracts;
using PodoApp.DB.Infrastructure.Entities;
using PodoApp.DB.Infrastructure.Mappers;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Repositories
{
    public class ConsultaRepository : BaseRepository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(PodologiaContext context) : base(context)
        {
        }

        #region Public Methods

        public void Delete(ConsultaModel model)
        {
            Delete(model.ModelToEntity());
        }

        public List<ConsultaModel> GetAllByPacienteId(Guid idPaciente)
        {
            return Get(x => x.id_paciente == idPaciente).Select(x => x.EntitytToModel()).ToList();
        }

        public void Insert(ConsultaModel model)
        {
            Insert(model.ModelToEntity());
        }

        public void Update(ConsultaModel model)
        {
            Update(model.ModelToEntity());
        }

        public ConsultaModel Get(Guid idConsulta)
        {
            return GetById(idConsulta).EntitytToModel();
        }

        #endregion

    }
}
