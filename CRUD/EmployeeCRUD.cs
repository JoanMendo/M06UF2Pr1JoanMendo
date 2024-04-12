using Classes;
using FluentNHibernate.Cfg;
using NHibernate.Criterion;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Npgsql;
using System;
using Conection;

namespace CRUDS;

public class EmployeeCRUD
{
   public void InsertADO(List<Employee> employees)
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
                

            }
        }
    }

    /*Insertar els següents nous empleats a la taula EMPLOYEE utilitzant el PreparedStatement. El mètode del
EmployeeCRUD.cs es dirà InsertADO i rep com a paràmetre una llista d’objectes Employee que crearàs en la
classe Program.cs. Si s’han inserit correctament els empleats el mètode InsertADO mostra a l’usuari el
missatge «Empleats inserits correctament».*/







    
    



}
