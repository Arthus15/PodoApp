using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Services
{
    public class ConsultaServiceTest
    {
        private readonly Mock<IConsultaService> _consultaServiceMock;

        public ConsultaServiceTest()
        {
            var mock = new MockFactory();

            _consultaServiceMock = mock.CreateMock<IConsultaService>();
        }

        [TestMethod]
        public void GetAllByPacienteId_Returns_ListOfTypeConsultaDto()
        {

        }
    }
}
