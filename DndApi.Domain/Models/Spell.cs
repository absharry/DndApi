using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    using Core.Enums;

    public class Spell : BaseModel
    {
        public Class PrimaryClass { get; set; }

        public List<Class> SubClasses { get; set; }

        public int SpellLevel { get; set; }

        public MagicSchool MagicSchool { get; set; }

        public string CastingTime { get; set; }

        public string Range { get; set; }

        public List<SpellComponents> Components { get; set; }

        public List<string> MaterialComponents { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        public bool Ritual { get; set; }                 
    }
}
