using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System;
using batdongsan.Model;
using Microsoft.EntityFrameworkCore;


namespace Service.Base
{

    public interface IBaseService<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void InsertMany(List<T> lstEntity);
        void DeleteMany(List<T> lstEntity);
        List<T> getAll();
        List<T> FindbyConditon(Expression<Func<T,bool>> expression);
        T findById(Expression<Func<T,bool>> expression);

        void save();
    } 
    public class BaseService<T>: IBaseService<T> where T : class
    {
        private readonly  ApplicationDbContext dbContext;
    
        public BaseService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public void InsertMany(List<T> lstEntity)
        {
            dbContext.Set<T>().AddRange(lstEntity);
        }

        public void DeleteMany(List<T> lstEntity)
        {
            dbContext.Set<T>().RemoveRange(lstEntity);
        }

        public List<T> getAll()
        {
            return dbContext.Set<T>().AsNoTracking().ToList();
        }

        public List<T> FindbyConditon(Expression<Func<T,bool>> expression)
        {
            return dbContext.Set<T>().Where(expression).ToList();
        }

        public T findById(Expression<Func<T,bool>> expression)
        {
            return dbContext.Set<T>().FirstOrDefault(expression);
        }

         public void save()
        {
            dbContext.SaveChanges();
        }
    }

}