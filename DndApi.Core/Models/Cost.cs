using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Core.Models
{
    using Enums;

    public class Cost
    {
        public int Quantity { get; set; }

        public CurrencyUnit Unit { get; set; }
    }
}
