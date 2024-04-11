using Classes;
using FluentNHibernate.Cfg;
using NHibernate.Criterion;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using Conection;

namespace CRUDS;

public class EmployeeCRUD
{
   public void InsertADO(List<Employee> employees)
    {
        using (var connection = new SessionFactoryLocal.Open())
        {

        }
    }


}
