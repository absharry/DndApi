using System;
using System.Collections.Generic;
using System.Text;
using DndApi.Core.Models;

namespace DndApi.Domain.Models
{
    public class Spellcasting : BaseModel
    {
        public Class Class { get; set; }

        public int Level { get; set; }

        public AbilityScore SpellcastingAbility { get; set; }

        public List<NameDescription> Info { get; set; }
    }
}
