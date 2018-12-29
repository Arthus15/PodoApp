using System;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class AntecedentesFamiliaresDto
    {
        public Guid idAFamiliares { get; set; }

        public bool dismetrias { get; set; }

        public bool escoliosis { get; set; }

        public bool tibiasVaras { get; set; }

        public bool piesPlanos { get; set; }

        public bool piesCavos { get; set; }

        public bool piesValgos { get; set; }

        public bool piesZambos { get; set; }

        public bool hallusValgus { get; set; }

        public bool dedosGarra { get; set; }

        public string otros { get; set; }

        public bool genuVaro { get; set; }

        public bool genuValgo { get; set; }

        public bool metaAductus { get; set; }

        public bool metaVarus { get; set; }
    }
}