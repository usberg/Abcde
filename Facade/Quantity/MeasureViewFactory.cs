﻿using Data.Quantity;
using Domain.Quantity;

namespace Facade.Quantity
{
    public static class MeasureViewFactory
    {
        public static Measure Create(MeasureView v)
        {
            var d = new MeasureData()
            {
                Id = v.Id,
                Name = v.Name,
                Code = v.Code,
                Definition = v.Definition,
                ValidFrom = v.ValidFrom,
                ValidTo = v.ValidTo
            };
            return new Measure(d);
        }
        public static MeasureView Create(Measure o)
        {
            var v = new MeasureView
            {
                Id = o.Data.Id,
                Name = o.Data.Name,
                Code = o.Data.Code,
                Definition = o.Data.Definition,
                ValidFrom = o.Data.ValidFrom,
                ValidTo = o.Data.ValidTo
            };
            return v;
        }
    }
}
