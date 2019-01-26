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
    public class MaterialSoportePlantarRepository : BaseRepository<MaterialSoportePlantar>, IMaterialSoportePlantarRepository
    {
        public MaterialSoportePlantarRepository(PodologiaContext context) : base(context)
        {
        }

        #region Public Methods

        public void Delete(MaterialSoportePlantarModel model)
        {
            Delete(model.ModelToEntity());
        }

        public MaterialSoportePlantarModel GetByIdTratamiento(Guid idTratamiento)
        {
            var materialSoporteSet = dbSet.ToList();
            return materialSoporteSet.Where(x => x.id_tratamiento == idTratamiento).FirstOrDefault().EntityToModel();
        }

        public void Insert(MaterialSoportePlantarModel model)
        {
            Insert(model.ModelToEntity());
        }

        public void Update(MaterialSoportePlantarModel model)
        {
            Update(model.ModelToEntity());
        }

        #endregion

    }
}
