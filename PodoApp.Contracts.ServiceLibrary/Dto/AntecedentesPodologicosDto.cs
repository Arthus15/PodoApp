using System;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class AntecedentesPodologicosDto
    {
        public Guid idAPodologicos { get; set; }

        public bool haidoPodologo { get; set; }

        public string antecedentes { get; set; }
    }
}