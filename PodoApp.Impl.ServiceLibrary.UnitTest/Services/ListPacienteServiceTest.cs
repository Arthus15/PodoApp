using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Impl.ServiceLibrary.Services;
using PodoApp.Library.Model;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Services
{
    [TestClass]
    public class ListPacienteServiceTest
    {
        private readonly Mock<IPacienteRepository> _pacienteRepositoryMock;
        private readonly IListaPacienteService _listaPacienteService;

        public ListPacienteServiceTest()
        {
            var mock = new MockFactory();

            _pacienteRepositoryMock = mock.CreateMock<IPacienteRepository>();

            _listaPacienteService = new ListaPacienteService(_pacienteRepositoryMock.MockObject);
        }

        [TestMethod]
        public void GetAll_Returns_CorrectType()
        {
            //Arrange
            _pacienteRepositoryMock.Expects.One.Method(x => x.GetAll()).WillReturn(new List<PacienteModel>() { new PacienteModel() { idPaciente = Guid.Empty } });

            //Act
            var result = _listaPacienteService.GetAll().ToList();

            //Assert
            Assert.AreEqual(result[0].idPaciente, Guid.Empty);

        }
    }
}
