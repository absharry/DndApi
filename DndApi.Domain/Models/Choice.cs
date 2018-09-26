using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class Choice<T> : BaseModel
    {
        public int AmountToChoose { get; set; }

        public string Type => nameof(T);

        public List<T> From { get; set; }
    }
}
