using FluentNHibernate.Mapping;
using Classes;

public class EmployeeMap : ClassMap<Employee>
{
    public EmployeeMap()
    {
        Table("employee");
        Id(x => x.Id).Column("id");
        Map(x => x.Surname).Column("surname");
        Map(x => x.Job).Column("job");
        Map(x => x.Managerno).Column("managerno");
        Map(x => x.startDate).Column("startdate");
        Map(x => x.Salary).Column("salary");
        Map(x => x.Commission).Column("commission");
        Map(x => x.DepartmentNo).Column("deptno");
    }
}