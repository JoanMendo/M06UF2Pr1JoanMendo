using Classes;
using FluentNHibernate.Cfg;
using NHibernate.Criterion;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using Conection;

namespace CRUDS;

public class ProductCRUD
{
    public void SelectByCodeADO(List<Employee> employees)
    {
        using (var connection = SessionFactoryLocal.Open())
        {
            using (var transaction = connection.BeginTransaction())
            {
                foreach (Employee employee in employees)
                {
                    connection.Save(employee);
                    Console.WriteLine($"Empleat {employee.Surname} afegit");
                }
                transaction.Commit();

            }
        }
    }


}