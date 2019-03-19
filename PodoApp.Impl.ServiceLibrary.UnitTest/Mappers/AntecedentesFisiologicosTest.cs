using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Impl.ServiceLibrary.Mappers;
using PodoApp.Library.Model;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Mappers
{
    [TestClass]
    public class AntecedentesFisiologicosTest
    {
        private readonly AntecedentesFisiologicosModel _antecedentesFisiologicosModel;
        private readonly AntecedentesFisiologicosDto _antecedentesFisiologicosDto;

        public AntecedentesFisiologicosTest()
        {
            _antecedentesFisiologicosModel = new AntecedentesFisiologicosModel()
            {
                idAFisiologico = Guid.NewGuid()
            };

            _antecedentesFisiologicosDto = new AntecedentesFisiologicosDto()
            {
                idAFisiologico = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void AntecedentesFisiologicosModel_Maps_To_Dto_CorrectType()
        {
            var antecedentesFisiologicosDto = _antecedentesFisiologicosModel.ModelToDto();
            Assert.AreEqual(typeof(AntecedentesFisiologicosDto), antecedentesFisiologicosDto.GetType());
        }

        [TestMethod]
        public void AntecedentesFisiologicosModel_Maps_To_Dto_Correctly()
        {
            var antecedentesFisiologicosDto = _antecedentesFisiologicosModel.ModelToDto();

            Assert.AreEqual(_antecedentesFisiologicosModel.idAFisiologico, antecedentesFisiologicosDto.idAFisiologico);
        }

        [TestMethod]
        public void AntecedentesFisiologicosDto_Maps_To_Model_CorrectType()
        {
            var antecedentesFisiologicosModel = _antecedentesFisiologicosDto.DtoToModel();

            Assert.AreEqual(typeof(AntecedentesFisiologicosModel), antecedentesFisiologicosModel.GetType());
        }

        [TestMethod]
        public void AntecedentesFisiologicosDto_Maps_To_Model_Correctly()
        {
            var antecedentesFisiologicosModel = _antecedentesFisiologicosDto.DtoToModel();

            Assert.AreEqual(_antecedentesFisiologicosDto.idAFisiologico, antecedentesFisiologicosModel.idAFisiologico);
        }
    }
}
