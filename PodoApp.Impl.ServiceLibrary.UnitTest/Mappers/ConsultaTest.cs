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
    public class ConsultaTest
    {
        private readonly ConsultaModel _consultaModel;
        private readonly ConsultaDto _consultaDto;

        public ConsultaTest()
        {
            _consultaModel = new ConsultaModel()
            {
                idConsulta = Guid.NewGuid()
            };

            _consultaDto = new ConsultaDto()
            {
                idConsulta = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void ConsultaModel_Maps_To_Dto_CorrectType()
        {
            var consultaDto = _consultaModel.ModelToDto();
            Assert.AreEqual(typeof(ConsultaDto), consultaDto.GetType());
        }

        [TestMethod]
        public void ConsultaModel_Maps_To_Dto_Correctly()
        {
            var consultaDto = _consultaModel.ModelToDto();

            Assert.AreEqual(_consultaModel.idConsulta, consultaDto.idConsulta);
        }

        [TestMethod]
        public void ConsultaDto_Maps_To_Model_CorrectType()
        {
            var consultaModel = _consultaDto.DtoToModel();

            Assert.AreEqual(typeof(ConsultaModel), consultaModel.GetType());
        }

        [TestMethod]
        public void ConsultaDto_Maps_To_Model_Correctly()
        {
            var consultaModel = _consultaDto.DtoToModel();

            Assert.AreEqual(_consultaDto.idConsulta, consultaModel.idConsulta);
        }
    }
}
