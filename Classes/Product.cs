public class Product
{
    public virtual int Id { get; set; }
    
    public virtual int Code { get; set; }

    public virtual string Description { get; set; }

    public virtual int CurrentStock { get; set; }

    public virtual int MinStock { get; set; }

    public virtual int Price { get; set; }

    public virtual int EmpNo { get; set; }
}