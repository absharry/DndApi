using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Core.Models
{
    public class ArmorClass
    {
        public int Base { get; set; }

        public bool HasDexBonus { get; set; }

        public int? MaxBonus { get; set; }
    }
}
