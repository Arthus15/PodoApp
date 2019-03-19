﻿using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Repositories
{
    public interface IMaterialSoportePlantarRepository : IBaseRepository<MaterialSoportePlantarModel>
    {
        MaterialSoportePlantarModel GetByIdTratamiento(Guid idTratamiento);
    }
}