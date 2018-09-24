using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class Class: BaseModel
    {
        public List<Levels> Levels { get; set; }
    }
}
