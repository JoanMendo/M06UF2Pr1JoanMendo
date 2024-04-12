using System;
using Classes;
using CRUDS;
using FluentNHibernate.Cfg;
using NHibernate.Criterion;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Npgsql;

namespace program;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        EmployeeCRUD employeeCRUD = new EmployeeCRUD();
        employees.Add(new Employee() { Surname = "SMITH", Commission = 52000, DepartmentNo = 10, Job = "DIRECTOR", Managerno = 9, Salary = 118000, startDate = new DateTime(1988, 12, 12) });
        employees.Add(new Employee() { Surname = "JOHNSON", Commission = 30000, DepartmentNo = 30, Job = "VENDEDOR", Managerno = 4, Salary = 125000, startDate = new DateTime(1992, 02, 25) });
        employees.Add(new Employee() { Surname = "HAMILTON", DepartmentNo = 10, Commission = 0, Job = "ANALISTA", Managerno = 7, Salary = 172000, startDate = new DateTime(1989, 03, 18) });
        employees.Add(new Employee() { Surname = "JACKSON", DepartmentNo = 10, Commission = 0, Id = 4, Job = "ANALISTA", Managerno = 7, Salary = 192000, startDate = new DateTime(2001, 10, 25) });
        Console.WriteLine("Ex 1");
        employeeCRUD.InsertADO(employees);
    }
}