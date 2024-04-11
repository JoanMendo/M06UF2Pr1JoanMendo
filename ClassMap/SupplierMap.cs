using FluentNHibernate.Mapping;
using Classes;
public class SupplierMap : ClassMap<Supplier>
{
    public SupplierMap()
    {
        Table("supplier");
        Id(x => x.Id).Column("id");
        Map(x => x.Name).Column("name");
        Map(x => x.Address).Column("address");
        Map(x => x.City).Column("city");
        Map(x => x.StCode).Column("stcode");
        Map(x => x.ZipCode).Column("zipcode");
        Map(x => x.Area).Column("area");
        Map(x => x.Phone).Column("phone");
        Map(x => x.ProductNo).Column("productno");
        Map(x => x.Amount).Column("amount");
        Map(x => x.Credit).Column("credit");
        Map(x => x.Remark).Column("remark");

    }
}
