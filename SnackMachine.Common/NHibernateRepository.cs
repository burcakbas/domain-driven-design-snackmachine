using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace SnackMachines.Common
{
    public abstract class NHibernateRepository<T> : IRepository<T> where T : IAggregateRoot
    {
        public T GetById(long id)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public void Save(T aggregateRoot)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(aggregateRoot);
                transaction.Commit();
            }
        }

        public IList<T> GetAll()
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Query<T>().ToList();
            }
        }
    }
}
