using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GererEmployes.Models.Repositories
{
    public interface IEmployestoreRepository<TEntity>
    {
        IList<TEntity> list();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
