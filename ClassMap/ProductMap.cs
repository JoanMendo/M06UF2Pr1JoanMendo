using FluentNHibernate.Mapping;
using Classes;
public class ProductMap: ClassMap<Product>
{
    public ProductMap()
    {
        Table("product");
        Id(x => x.Id).Column("id");
        Map(x => x.Code).Column("code");
        Map(x => x.Description).Column("description");
        Map(x => x.CurrentStock).Column("currentstock");
        Map(x => x.MinStock).Column("minstock");
        Map(x => x.Price).Column("price");
        Map(x => x.EmpNo).Column("empno");
    }
}
