using Database.Interfaces;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Database
{
    public class DatabaseConnection<T> : IDatabaseConnection<T> where T : class
    {
        private ISessionFactory _sessionFactory;
        public DatabaseConnection()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Domain.Log).Assembly);

            _sessionFactory = cfg.BuildSessionFactory();
            new SchemaExport(cfg).Create(true, true);
        }

        public void Add(T entity)
        {
            var session = _sessionFactory.OpenSession();
            session.Save(entity);
            session.Flush();
            session.Close();
        }
    }
}
