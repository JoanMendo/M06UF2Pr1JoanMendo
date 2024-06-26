﻿using FluentNHibernate.Mapping;
using Classes;
public class OrderMap : ClassMap<Order>
{
    public OrderMap()
    {
        Table("orderp");
        Id(x => x.Id).GeneratedBy.Identity();
        Map(x => x.SupplierId).Column("supplierno");
        Map(x => x.OrderDate).Column("orderdate");
        Map(x => x.Amount).Column("amount");
        Map(x => x.DeliveryDate).Column("deliverydate");
        Map(x => x.Cost).Column("cost");
    }
}