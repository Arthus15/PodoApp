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
    public class AntecedentesPodologicosTest
    {
        private readonly AntecedentesPodologicosModel _antecedentesPodologicosModel;
        private readonly AntecedentesPodologicosDto _antecedentesPodologicosDto;

        public AntecedentesPodologicosTest()
        {
            _antecedentesPodologicosDto = new AntecedentesPodologicosDto()
            {
                idAPodologicos = Guid.NewGuid()
            };

            _antecedentesPodologicosModel = new AntecedentesPodologicosModel()
            {
                idAPodologicos = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void AntecedentesPodologicosModel_Maps_To_Dto_CorrectType()
        {
            var antecedentesPodologicosDto = _antecedentesPodologicosModel.ModelToDto();
            Assert.AreEqual(typeof(AntecedentesPodologicosDto), antecedentesPodologicosDto.GetType());
        }

        [TestMethod]
        public void AntecedentesPodologicosModel_Maps_To_Dto_Correctly()
        {
            var antecedentesPodologicosDto = _antecedentesPodologicosModel.ModelToDto();

            Assert.AreEqual(_antecedentesPodologicosModel.idAPodologicos, antecedentesPodologicosDto.idAPodologicos);
        }

        [TestMethod]
        public void AntecedentesPodologicosDto_Maps_To_Model_CorrectType()
        {
            var antecedentesPodologicosModel = _antecedentesPodologicosDto.DtoToModel();

            Assert.AreEqual(typeof(AntecedentesPodologicosModel), antecedentesPodologicosModel.GetType());
        }

        [TestMethod]
        public void AntecedentesPodologicosDto_Maps_To_Model_Correctly()
        {
            var antecedentesPodologicosModel = _antecedentesPodologicosDto.DtoToModel();

            Assert.AreEqual(_antecedentesPodologicosDto.idAPodologicos, antecedentesPodologicosModel.idAPodologicos);
        }
    }
}
