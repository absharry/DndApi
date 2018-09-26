using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    using Core.Enums;

    public class EquipmentPack: AdventuringGear
    {
        public List<Equipment<GearCategory>> Contents { get; set; }
    }
}
