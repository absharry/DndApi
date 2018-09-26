using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    using Core.Enums;
    using Core.Models;

    public class Equipment<T>: BaseModel
    {
        public T Category { get; set; }

        public Cost Cost { get; set; }

        public int? Weight { get; set; }

        public string Description { get; set; }
    }
}
