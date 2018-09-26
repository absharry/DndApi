using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    using Core.Enums;
    using Core.Models;

    public class Vehicle: Equipment<VehicleCategory>
    {
        public Speed Speed { get; set; }

        public Capacity Capacity { get; set; }
    }
}
