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
        private readonly AntecedentesFisiologicosModel AntecedentesFisiologicosModel;
        private readonly AntecedentesFisiologicosDto AntecedentesFisiologicosDto;

        public AntecedentesFisiologicosTest()
        {
            AntecedentesFisiologicosModel = new AntecedentesFisiologicosModel()
            {
                idAFisiologico = Guid.NewGuid()
            };

            AntecedentesFisiologicosDto = new AntecedentesFisiologicosDto()
            {
                idAFisiologico = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void AntecedentesFisiologicosModel_Maps_To_Dto_CorrectType()
        {
            var antecedentesFisiologicosDto = AntecedentesFisiologicosModel.ModelToDto();
            Assert.AreEqual(typeof(AntecedentesFisiologicosDto), antecedentesFisiologicosDto.GetType());
        }

        [TestMethod]
        public void AntecedentesFisiologicosModel_Maps_To_Dto_Correctly()
        {
            var antecedentesFisiologicosDto = AntecedentesFisiologicosModel.ModelToDto();

            Assert.AreEqual(AntecedentesFisiologicosModel.idAFisiologico, antecedentesFisiologicosDto.idAFisiologico);
        }

        [TestMethod]
        public void AntecedentesFisiologicosDto_Maps_To_Model_CorrectType()
        {
            var antecedentesFisiologicosModel = AntecedentesFisiologicosDto.DtoToModel();

            Assert.AreEqual(typeof(AntecedentesFisiologicosModel), antecedentesFisiologicosModel.GetType());
        }

        [TestMethod]
        public void AntecedentesFisiologicosDto_Maps_To_Model_Correctly()
        {
            var antecedentesFisiologicosModel = AntecedentesFisiologicosDto.DtoToModel();

            Assert.AreEqual(AntecedentesFisiologicosDto.idAFisiologico, antecedentesFisiologicosModel.idAFisiologico);
        }
    }
}
