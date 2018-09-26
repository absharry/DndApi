using System;

namespace DndApi.Authentication.Models
{
    public class Application
    {
        public Application(string name)
        {
            this.AppKey = Guid.NewGuid();
            this.AppName = name;
            this.AppKeyCreated = DateTime.UtcNow;
        }

        public int ID { get; set; }

        public Guid AppKey { get; set; }

        public string AppName { get; set; }

        public DateTime AppKeyCreated { get; set; }
    }
}
