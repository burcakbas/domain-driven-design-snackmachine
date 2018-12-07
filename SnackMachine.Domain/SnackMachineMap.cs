using FluentNHibernate;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Domain
{
    public class SnackMachineMap : ClassMap<SnackMachine>
    {
        public SnackMachineMap()
        {
            Id(x => x.Id);

            Component(x => x.MoneyInside, y =>
            {
                y.Map(x => x.OneCentCount);
                y.Map(x => x.TenCentCount);
                y.Map(x => x.QuarterCount);
                y.Map(x => x.OneDollarCount);
                y.Map(x => x.FiveDollarCount);
                y.Map(x => x.TwentyDollarCount);
            });

            HasMany<Slot>(Reveal.Member<SnackMachine>("Slots"))
                .Cascade.SaveUpdate()
                .Not.LazyLoad()
                .Inverse();
        }
    }
}
