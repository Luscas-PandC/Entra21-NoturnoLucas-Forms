using AcademiaEF6.Dominio;
using System.Data.Entity;

namespace AcademiaEF6.Repository
{
    class RepositorioModalidade
    {
        public int AddOrUpdate(Modalidade modalidade, bool addOrUpdate)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                    db.Set<Modalidade>().Attach(modalidade);

                if (addOrUpdate)
                {
                    db.Entry(modalidade).State = EntityState.Added;
                }
                else
                {
                    db.Entry(modalidade).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Modalidade modalidade)
        {
            using (var db = new AcademiaContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                    db.Set<Modalidade>().Attach(modalidade);

                db.Entry(modalidade).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
