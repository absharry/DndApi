using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class AbilityScore : BaseModel
    {
        public string ShortenedName { get; set; }

        public string Description { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
