using System;
using System.Collections.Generic;
using System.Text;

namespace DndApi.Domain.Models
{
    public class BaseModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public string DataSource { get; set; }
    }
}
