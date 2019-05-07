using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Impl.ServiceLibrary.Services;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Services
{
    [TestClass]
    public class ConsultaServiceTest
    {
        private readonly Mock<IConsultaRepository> _consultaRepositoryMock;
        private readonly IConsultaService _consultaService;

        public ConsultaServiceTest()
        {
            var mock = new MockFactory();
            _consultaRepositoryMock = mock.CreateMock<IConsultaRepository>();

            _consultaService = new ConsultaService(_consultaRepositoryMock.MockObject);

        }

        [TestMethod]
        public void GetAllByPacienteId_Returns_ListOfTypeConsultaDto()
        {
            //Arrange
            List<ConsultaModel> returnList = new List<ConsultaModel>() { new ConsultaModel() { idConsulta = Guid.Empty } };
            _consultaRepositoryMock.Expects.One.Method(x => x.GetAllByPacienteId(Guid.Empty)).With(Is.TypeOf(typeof(Guid))).WillReturn(returnList);

            //Act
            var result = _consultaService.GetAllByPacienteId(Guid.Empty);

            //Assert
            Assert.AreEqual(typeof(List<ConsultaDto>), result.GetType());
            Assert.AreEqual(returnList[0].idConsulta, result[0].idConsulta);

        }

        [TestMethod]
        public void Get_returns_ConsultaDto()
        {
            //Arrange
            ConsultaModel consulta = new ConsultaModel() { idConsulta = Guid.NewGuid(), descripcion = string.Empty, fecha = DateTime.Today };
            _consultaRepositoryMock.Expects.One.Method(x => x.Get(Guid.Empty)).With(Is.TypeOf(typeof(Guid))).WillReturn(consulta);

            //Act
            var result = _consultaService.Get(Guid.Empty);

            //Assert
            Assert.AreEqual(typeof(ConsultaDto), result.GetType());
            Assert.AreEqual(consulta.idConsulta, result.idConsulta);
            Assert.AreEqual(consulta.descripcion, result.descripcion);
            Assert.AreEqual(consulta.fecha, result.fecha);
        }
    }
}
