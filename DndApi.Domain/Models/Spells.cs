using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    using Enums;

    public class Spells : BaseModel
    {
        public Race PrimaryRace { get; set; }

        public int SpellLevel { get; set; }

        public MagicSchool MagicSchool { get; set; }

        public string CastingTime { get; set; }

        public string Range { get; set; }

        public List<SpellComponents> Components { get; set; }

        public List<string> MaterialComponents { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }
    }
}
