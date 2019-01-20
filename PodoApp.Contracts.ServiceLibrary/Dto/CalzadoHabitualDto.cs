using System;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class CalzadoHabitualDto
    {
        public Guid idCalzado { get; set; }

        public bool deportivos { get; set; }

        public bool vestir { get; set; }

        public bool sandalias { get; set; }

        public bool botines { get; set; }

        public bool tacones { get; set; }
    }
}
