using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library
{
    public interface IBaseRepository<TModel> where TModel : class
    {
        void Insert(TModel model);

        void Delete(TModel model);

        void Update(TModel model);
     }
}
