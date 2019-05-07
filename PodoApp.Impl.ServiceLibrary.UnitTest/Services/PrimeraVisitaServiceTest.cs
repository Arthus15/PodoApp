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
    public class PrimeraVisitaServiceTest
    {
        private readonly Mock<IPrimeraVisitaRepository> _primeraVisitaRepositoryMock;
        private readonly Mock<ICalzadoHabitualRepository> _calzadoHabitualRepositoryMock;
        private readonly Mock<IPodologoRepository> _podologoRepositoryMock;
        private readonly Mock<IPersonaRepository> _personaRepositoryMock;
        private readonly IPrimeraVisitaService _primeraVisitaService;

        public PrimeraVisitaServiceTest()
        {
            var mock = new MockFactory();

            _primeraVisitaRepositoryMock = mock.CreateMock<IPrimeraVisitaRepository>();
            _calzadoHabitualRepositoryMock = mock.CreateMock<ICalzadoHabitualRepository>();
            _podologoRepositoryMock = mock.CreateMock<IPodologoRepository>();
            _personaRepositoryMock = mock.CreateMock<IPersonaRepository>();

            _primeraVisitaService = new PrimeraVisitaService(_primeraVisitaRepositoryMock.MockObject, _calzadoHabitualRepositoryMock.MockObject,
                _personaRepositoryMock.MockObject, _podologoRepositoryMock.MockObject);
        }

        [TestMethod]
        public void GetPodologos_Returns_Ok()
        {
            //Arrange
            var idPersona = Guid.NewGuid();
            var podologoList = new List<PodologoModel>() { new PodologoModel() { id_persona = idPersona, idPodologo = Guid.NewGuid() } };
            _podologoRepositoryMock.Expects.AtLeast(1).Method(x => x.GetAllIds()).WillReturn(podologoList);
            _personaRepositoryMock.Expects.AtLeast(1).Method(x => x.GetByIdList(new List<Guid>() {idPersona })).WithAnyArguments()
                .WillReturn(new List<PersonaModel>{ new PersonaModel() { idPersona = idPersona, nombre = "Jairo"} });

            //Act
            var result = _primeraVisitaService.GetPodologos();

            //Assert
            Assert.AreEqual(result[0].IdPersona, idPersona);
            Assert.AreEqual(result[0].IdPodologo, podologoList[0].idPodologo);
            Assert.AreEqual(result[0].Nombre, "Jairo");
        }

        [TestMethod]
        public void Get_Return_Ok()
        {
            //Arrange
            _primeraVisitaRepositoryMock.Expects.AtLeast(1).Method(x => x.Get(Guid.Empty)).WithAnyArguments().WillReturn(new PrimeraVisitaModel() { idPrimeraVisita = Guid.Empty });

            //Act
            var result = _primeraVisitaService.Get(Guid.Empty);

            //Assert
            Assert.AreEqual(typeof(PrimeraVisitaDto), result.GetType());
            Assert.AreEqual(result.idPrimeraVisita, Guid.Empty);
        }

    }
}
