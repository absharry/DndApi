using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Core.Models
{
    using Enums;

    public class Speed
    {
        public int Quantity { get; set; }

        public SpeedUnit Unit { get; set; }
    }
}
