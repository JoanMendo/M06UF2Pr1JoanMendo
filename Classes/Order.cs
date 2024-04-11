namespace Classes;
public class Order
{
    public virtual int Id { get; set; }
    public virtual int SupplierId { get; set; }
    public virtual DateTime OrderDate { get; set; }

    public virtual int Amount { get; set; }
    public virtual DateTime DeliveryDate { get; set; }
    public virtual int Cost { get; set; }
}