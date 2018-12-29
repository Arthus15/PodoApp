using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
     }
}
