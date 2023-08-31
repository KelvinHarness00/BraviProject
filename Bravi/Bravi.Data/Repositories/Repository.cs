using Bravi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Bravi.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bravi.Data.Repositories
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Properties
        protected readonly BraviContext _braviContext;

        protected DbSet<TEntity> _context
        {
            get
            {
                return _braviContext.Set<TEntity>();
            }
        }

        #endregion

        public Repository(BraviContext braviContext)
        {
            _braviContext = braviContext;
        }

        #region Methods
        public TEntity Create(TEntity model)
        {
            try
            {
                _context.Add(model);
                Save();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TEntity> Create(List<TEntity> model)
        {
            try
            {
                _context.AddRange(model);
                Save();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(TEntity model)
        {
            try
            {
                _context.Update(model);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(List<TEntity> models)
        {
            try
            {
                _context.UpdateRange(models);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<TEntity> CreateAsync(TEntity model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity model)
        {
            try
            {
                _context.Remove(model);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(params object[] Keys)
        {
            try
            {
                var entity = _context.Find(Keys); // Encontre a entidade pelos parâmetros das chaves
                if (entity != null)
                {
                    _context.Remove(entity);
                    Save();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                var entities = _context.Where(where); // Encontre as entidades pelo predicado
                _context.RemoveRange(entities);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TEntity model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _braviContext.Dispose();
        }


        public TEntity Find(params object[] Keys)
        {
            return _context.Find(Keys);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> where)
        {
            return _context.FirstOrDefault(where); // Use FirstOrDefault para encontrar a primeira entidade que corresponda à condição
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes)
        {
            var query = _context.AsQueryable();

            if (includes != null)
            {
                query = includes(query) as IQueryable<TEntity>;
            }

            return query.FirstOrDefault(predicate);
        }

        public int Save()
        {
            try
            {
                return _braviContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Async and More
        public Task<TEntity> GetAsync(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity model)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
