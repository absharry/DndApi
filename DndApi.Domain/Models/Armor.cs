using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    using Core.Enums;
    using Core.Models;

    public class Armor : Equipment<ArmorCategory>
    {
        public ArmorClass ArmorClass { get; set; }

        public int StrengthMinimum { get; set; }
        
        public bool StealthDisadvantage { get; set; }
    }
}
