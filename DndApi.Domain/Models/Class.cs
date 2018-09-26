using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class Class: BaseModel
    {
        public List<Level> Levels { get; set; }

        public int HitDie { get; set; }

        public List<Choice<Proficiency>> ProficiencyChoices { get; set; }

        public List<Proficiency> Proficiencies { get; set; }

        public List<AbilityScore> SavingThrows { get; set; }

        public StartingEquipment StartingEquipment { get; set; }

        public List<Class> SubClasses { get; set; }

        public List<Spell> Spells { get; set; }

        public Spellcasting Spellcasting { get; set; }
    }
}
