using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Classes;

namespace Conection;

public class SessionFactoryLocal

{
    private static string ConnectionString = "Server=127.0.0.1;Port=5432;Database=training;User Id=training;Password=training;";
    private static ISessionFactory session;

    public static ISessionFactory CreateSession()
    {
        if (session != null)
            return session;

        IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
        var configMap =
            Fluently.Configure().Database(configDB).Mappings(
                c => c.FluentMappings.AddFromAssemblyOf<Employee>().AddFromAssemblyOf<Order>().AddFromAssemblyOf<Product>().AddFromAssemblyOf<Supplier>());


        session = configMap.BuildSessionFactory();

        return session;
    }

    public static ISession Open()
    {
        return CreateSession().OpenSession();
    }
}



