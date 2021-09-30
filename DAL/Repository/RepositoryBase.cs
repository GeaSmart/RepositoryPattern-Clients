using DAL.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepositoryBase<T>:IRepositoryBase<T> where T:BaseEntity
    {
        private readonly ApplicationDBContext context;
        //Constructor
        public RepositoryBase(ApplicationDBContext context)
        {
            this.context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await this.context.SaveChangesAsync();
        }
        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }
        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await this.context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await this.context.Set<T>().Where(expression).ToListAsync();
        }
    }
}
