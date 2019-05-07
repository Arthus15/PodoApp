using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Impl.ServiceLibrary.Services;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using System;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Services
{
    [TestClass]
    public class PacienteServiceTest
    {
        private readonly Mock<IPacienteRepository> _pacienteRepositoryMock;
        private readonly IPacienteService _pacienteService;

        public PacienteServiceTest()
        {
            var mock = new MockFactory();

            _pacienteRepositoryMock = mock.CreateMock<IPacienteRepository>();

            _pacienteService = new PacienteService(_pacienteRepositoryMock.MockObject);
        }

        [TestMethod]
        public void Get_Returns_CorrectType()
        {
            //Arrange
            _pacienteRepositoryMock.Expects.AtMost(1).Method(x => x.GetById(Guid.Empty)).With(Is.TypeOf(typeof(Guid))).WillReturn(new PacienteModel() { idPaciente = Guid.Empty });

            //Act
            var result = _pacienteService.Get(Guid.Empty);

            //Assert
            Assert.AreEqual(typeof(PacienteDto), result.GetType());
        }

        [TestMethod]
        public void Exists_Return_FalseWhenPacientIsNull()
        {
            //Arrange
            _pacienteRepositoryMock.Expects.AtMost(1).Method(x => x.Exists(Guid.Empty)).With(Is.TypeOf(typeof(Guid))).WillReturn(false);

            //Act
            var result = _pacienteService.Exists(Guid.Empty);

            //Assert
            Assert.AreEqual(result, false);

        }

        [TestMethod]
        public void Exists_Return_TrueWhenPacientIsNotNull()
        {
            //Arrange
            _pacienteRepositoryMock.Expects.AtMost(1).Method(x => x.Exists(Guid.Empty)).WithArguments(Is.TypeOf(typeof(Guid))).WillReturn(true);

            //Act
            var result = _pacienteService.Exists(Guid.Empty);

            //Assert
            Assert.AreEqual(result, true);

        }
    }
}
