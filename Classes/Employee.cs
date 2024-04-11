namespace Classes;
public class Employee
{
    public virtual int Id { get; set; }
    public virtual string Surname { get; set; }
    public virtual string Job { get; set; }
    public virtual int Managerno { get; set; }
    public virtual DateTime startDate { get; set; }
    public virtual int Salary { get; set; }

    public virtual int Commission { get; set; }

    public virtual int DepartmentNo { get; set; }
}