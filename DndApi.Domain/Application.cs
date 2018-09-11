using System;

namespace DndApi.Domain
{
    public class Application
    {
        public Application(string name)
        {
            this.AppKey = Guid.NewGuid();
            this.AppName = name;
            this.AppKeyCreated = DateTime.UtcNow;
        }

        public Guid AppKey { get; set; }

        public string AppName { get; set; }

        public DateTime AppKeyCreated { get; set; }
    }
}
