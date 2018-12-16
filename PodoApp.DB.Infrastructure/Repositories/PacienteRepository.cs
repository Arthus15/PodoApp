using PodoApp.DB.Infrastructure.Abstracts;
using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Repositories;

namespace PodoApp.DB.Infrastructure.Repositories
{
    public class PacienteRepository : BaseRepository<Paciente>, IPacienteRepository 
    {
        public PacienteRepository(PodologiaContext context) : base(context)
        {
            
        }        
    }
}
