using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Core.Models
{
    using Enums;

    public class Capacity
    {
        public int Quantity { get; set; }

        public CapacityUnit Unit { get; set; }
    }
}
