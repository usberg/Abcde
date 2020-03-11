using Data.Quantity;
using Domain.Common;

namespace Domain.Quantity
{
    public class Measure : Entity<MeasureData>
    {
        public Measure(MeasureData data) : base(data)
        {

        }
    }
}
