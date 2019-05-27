using Newtonsoft.Json;
using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PodoApp.DB.Infrastructure.Abstracts
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        internal PodologiaContext context;
        internal DbSet<TEntity> dbSet;
        internal DbSet<Audit> audit;

        internal string INSERT_OPERATION = "Insert";
        internal string UPDATE_OPERATION = "Update";
        internal string DELETE_OPERATION = "Delete";

        public BaseRepository(PodologiaContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
            audit = context.Set<Audit>();
        }

        #region Public Methods

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            AuditMethod(typeof(TEntity).ToString(), INSERT_OPERATION, JsonConvert.SerializeObject(entity));
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = GetById(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }

            dbSet.Remove(entity);

            AuditMethod(typeof(TEntity).ToString(), DELETE_OPERATION, JsonConvert.SerializeObject(entity));
        }

        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            AuditMethod(typeof(TEntity).ToString().Split('.')[typeof(TEntity).ToString().Split('.').Length - 1], UPDATE_OPERATION, JsonConvert.SerializeObject(entity));

        }

        #endregion

        #region Private Methods

        private void AuditMethod(string table, string operation, string newValue)
        {
                var auditory = audit.Create();
                auditory = new Audit() {Id = 100,UserName = HttpContext.Current.GetOwinContext().Authentication.User.Identity.Name, NewValue = newValue, Operation = operation, TableName = table, DateTime = DateTime.Now };              
                audit.Add(auditory);
                context.SaveChanges();
        }

        #endregion
    }
}
