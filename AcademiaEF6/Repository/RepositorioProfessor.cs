using AcademiaEF6.Dominio;
using System.Data.Entity;

namespace AcademiaEF6.Repository
{
    class RepositorioProfessor
    {
        public int AddOrUpdate(Professor professor, bool addOrUpdate)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);

                if (addOrUpdate)
                {
                    db.Entry(professor).State = EntityState.Added;
                }
                else
                {
                    db.Entry(professor).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Professor professor)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);

                db.Entry(professor).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
