using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Impl.ServiceLibrary.Mappers;
using PodoApp.Library.Model;

namespace PodoApp.Impl.ServiceLibrary.UnitTest.Mappers
{
    [TestClass]
    public class AntecedentesFamiliaresTest
    {
        private readonly AntecedentesFamiliaresModel AntecedentesFamiliaresModel;
        private readonly AntecedentesFamiliaresDto AntecedentesFamiliaresDto;

        public AntecedentesFamiliaresTest()
        {
            AntecedentesFamiliaresModel = new AntecedentesFamiliaresModel()
            {
                idAFamiliares = Guid.NewGuid(),
                otros = string.Empty
            };

            AntecedentesFamiliaresDto = new AntecedentesFamiliaresDto()
            {
                idAFamiliares = Guid.NewGuid(),
                otros = string.Empty
            };
        }

        [TestMethod]
        public void AntecedentesFamiliaresModel_Maps_To_Dto_CorrectType()
        {
            var antecedentesFamiliaresDto = AntecedentesFamiliaresModel.ModelToDto();            
            Assert.AreEqual(typeof(AntecedentesFamiliaresDto), antecedentesFamiliaresDto.GetType());
        }

        [TestMethod]
        public void AntecedentesFamiliaresModel_Maps_To_Dto_Correctly()
        {
            var antecedentesFamiliaresDto = AntecedentesFamiliaresModel.ModelToDto();

            Assert.AreEqual(antecedentesFamiliaresDto.idAFamiliares, AntecedentesFamiliaresModel.idAFamiliares);
            Assert.AreEqual(antecedentesFamiliaresDto.otros, AntecedentesFamiliaresModel.otros);
        }

        [TestMethod]
        public void AntecedentesFamiliaresDto_Maps_To_Model_CorrectType()
        {
            var antecedentesFamiliaresModel = AntecedentesFamiliaresDto.DtoToModel();

            Assert.AreEqual(typeof(AntecedentesFamiliaresModel), antecedentesFamiliaresModel.GetType());
        }

        [TestMethod]
        public void AntecedentesFamiliaresDto_Maps_To_Model_Correctly()
        {
            var antecedentesFamiliaresModel = AntecedentesFamiliaresDto.DtoToModel();

            Assert.AreEqual(antecedentesFamiliaresModel.idAFamiliares, AntecedentesFamiliaresDto.idAFamiliares);
            Assert.AreEqual(antecedentesFamiliaresModel.otros, AntecedentesFamiliaresDto.otros);
        }

    }
}
