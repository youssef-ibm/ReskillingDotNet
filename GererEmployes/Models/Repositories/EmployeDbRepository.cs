using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GererEmployes.Models.Repositories
{
    public class EmployeDbRepository : IEmployestoreRepository<Employe>
    {
        EmployeDbContext db;
        public EmployeDbRepository(EmployeDbContext _db)
        {
            db = _db;
        }

        public void Add(Employe entity)
        {
            db.Employes.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = Find(id);
            db.Employes.Remove(author);
            db.SaveChanges();
        }

        public Employe Find(int id)
        {
            return db.Employes.SingleOrDefault(a => a.Id == id);
        }

        public IList<Employe> list()
        {
            return db.Employes.ToList();
        }

        public void Update( Employe entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    }
}
