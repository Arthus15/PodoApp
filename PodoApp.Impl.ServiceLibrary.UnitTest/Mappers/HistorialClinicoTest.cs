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
    public class HistorialClinicoTest
    {
        private readonly HistorialClinicoModel _historialClinicoModel;
        private readonly HistorialClinicoDto _historialClinicoDto;

        public HistorialClinicoTest()
        {
            _historialClinicoDto = new HistorialClinicoDto()
            {
                idHistorialClinico = Guid.NewGuid()
            };

            _historialClinicoModel = new HistorialClinicoModel()
            {
                idHistorialClinico = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void HistorialClinicoModel_Maps_To_Dto_CorrectType()
        {
            var historialClinicoDto = _historialClinicoModel.ModelToDto();
            Assert.AreEqual(typeof(HistorialClinicoDto), historialClinicoDto.GetType());
        }

        [TestMethod]
        public void HistorialClinicoModel_Maps_To_Dto_Correctly()
        {
            var historialClinicoDto = _historialClinicoModel.ModelToDto();

            Assert.AreEqual(_historialClinicoModel.idHistorialClinico, historialClinicoDto.idHistorialClinico);
        }

        [TestMethod]
        public void HistorialClinicoDto_Maps_To_Model_CorrectType()
        {
            var historialClinicoDto = _historialClinicoDto.DtoToModel();

            Assert.AreEqual(typeof(HistorialClinicoModel), historialClinicoDto.GetType());
        }

        [TestMethod]
        public void HistorialClinicoDto_Maps_To_Model_Correctly()
        {
            var historialClinicoDto = _historialClinicoDto.DtoToModel();

            Assert.AreEqual(_historialClinicoDto.idHistorialClinico, historialClinicoDto.idHistorialClinico);
        }
    }
}
