using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class Race : BaseModel
    {
        public int StrengthModifier { get; set; }

        public int DexterityModifier { get; set; }

        public int ConstitutionModifier { get; set; }

        public int IntelligenceModifier { get; set; }

        public int WisdomModifier { get; set; }

        public int CharismaModifier { get; set; }

        public List<Race> SubRaces { get; set; }

        public int BaseSpeed { get; set; }

        public List<RaceTraits> Traits { get; set; }
    }
}
