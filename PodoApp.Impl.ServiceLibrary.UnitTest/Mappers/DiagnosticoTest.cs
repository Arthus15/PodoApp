using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Impl.ServiceLibrary.Mappers;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Mappers
{
    [TestClass]
    public class DiagnosticoTest
    {
        private readonly DiagnosticoModel _diagnosticoModel;
        private readonly DiagnosticoDto _diagnosticoDto;

        public DiagnosticoTest()
        {
            _diagnosticoModel = new DiagnosticoModel()
            {
                idDiagnostico = Guid.NewGuid()
            };

            _diagnosticoDto = new DiagnosticoDto()
            {
                idDiagnostico = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void DiagnosticoModel_Maps_To_Dto_CorrectType()
        {
            var diagnosticoDto = _diagnosticoModel.ModelToDto();
            Assert.AreEqual(typeof(DiagnosticoDto), diagnosticoDto.GetType());
        }

        [TestMethod]
        public void DiagnosticoModel_Maps_To_Dto_Correctly()
        {
            var diagnosticoDto = _diagnosticoModel.ModelToDto();

            Assert.AreEqual(_diagnosticoModel.idDiagnostico, diagnosticoDto.idDiagnostico);
        }

        [TestMethod]
        public void DiagnosticoDto_Maps_To_Model_CorrectType()
        {
            var diagnosticoModel = _diagnosticoDto.DtoToModel();

            Assert.AreEqual(typeof(DiagnosticoModel), diagnosticoModel.GetType());
        }

        [TestMethod]
        public void DiagnosticoDto_Maps_To_Model_Correctly()
        {
            var diagnosticoModel = _diagnosticoDto.DtoToModel();

            Assert.AreEqual(_diagnosticoDto.idDiagnostico, diagnosticoModel.idDiagnostico);
        }
    }
}
