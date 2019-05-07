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
    public class DiagnosticoTratamientoServiceTest
    {
        private readonly Mock<IDiagnosticoRepository> _diagnosticoRepositoryMock;
        private readonly Mock<ITratamientoRepository> _tratamientoRepositoryMock;
        private readonly Mock<IMaterialSoportePlantarRepository> _materialSoportePlantarRepositoryMock;
        private readonly IDiagnosticoTratamientoService _diagnosticoTratamientoService;

        public DiagnosticoTratamientoServiceTest()
        {
            var mock = new MockFactory();

            _diagnosticoRepositoryMock = mock.CreateMock<IDiagnosticoRepository>();
            _tratamientoRepositoryMock = mock.CreateMock<ITratamientoRepository>();
            _materialSoportePlantarRepositoryMock = mock.CreateMock<IMaterialSoportePlantarRepository>();

            _diagnosticoTratamientoService = new DiagnosticoTratamientoService(_diagnosticoRepositoryMock.MockObject, 
                _tratamientoRepositoryMock.MockObject, _materialSoportePlantarRepositoryMock.MockObject);
        }
        
        [TestMethod]
        public void Get_Return_ObjectList()
        {
            //Arrange
            _diagnosticoRepositoryMock.Expects.One.Method(x => x.GetByid(Guid.Empty))
                .With(Is.TypeOf(typeof(Guid))).WillReturn(new DiagnosticoModel() { idDiagnostico = Guid.Empty, id_tratamiento = Guid.Empty});
            _materialSoportePlantarRepositoryMock.Expects.One.Method(x => x.GetByIdTratamiento(Guid.Empty)).With(Is.TypeOf(typeof(Guid)))
                .WillReturn(new MaterialSoportePlantarModel() { idMaterialSoportePlantar = Guid.Empty, id_tratamiento = Guid.Empty });

            //Act
            var result = _diagnosticoTratamientoService.Get(Guid.Empty);
            var consultaDto = (DiagnosticoDto)result[0];
            var materialSoportePlantarDto = (MaterialSoportePlantarDto)result[1];
            //Assert
            Assert.AreEqual(typeof(DiagnosticoDto),consultaDto.GetType());
            Assert.AreEqual(typeof(MaterialSoportePlantarDto), materialSoportePlantarDto.GetType());
        }
    }
}
