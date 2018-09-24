using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class Levels : BaseModel
    {
        public int ProficiencyBonus { get; set; }

        public string Features { get; set; }

        public Class Class { get; set; }

        public int? Rages { get; set; }

        public int? RageDamage { get; set; }

        public int? CantripsKnown { get; set; }

        public int? SpellsKnown { get; set; }

        public Dictionary<int, int> SpellSlots { get; set; }

        public int? MartialArtsDice { get; set; }

        public int? KiPoints { get; set; }

        public int? UnarmoredMovement { get; set; }

        public int? SneakAttackMultiplier { get; set; }

        public int? SorceryPoints { get; set; }

        public int? InvocationKnown { get; set; }
    }
}
