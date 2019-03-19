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
        private readonly AntecedentesFamiliaresModel _antecedentesFamiliaresModel;
        private readonly AntecedentesFamiliaresDto _antecedentesFamiliaresDto;

        public AntecedentesFamiliaresTest()
        {
            _antecedentesFamiliaresModel = new AntecedentesFamiliaresModel()
            {
                idAFamiliares = Guid.NewGuid(),
                otros = string.Empty
            };

            _antecedentesFamiliaresDto = new AntecedentesFamiliaresDto()
            {
                idAFamiliares = Guid.NewGuid(),
                otros = string.Empty
            };
        }

        [TestMethod]
        public void AntecedentesFamiliaresModel_Maps_To_Dto_CorrectType()
        {
            var antecedentesFamiliaresDto = _antecedentesFamiliaresModel.ModelToDto();            
            Assert.AreEqual(typeof(AntecedentesFamiliaresDto), antecedentesFamiliaresDto.GetType());
        }

        [TestMethod]
        public void AntecedentesFamiliaresModel_Maps_To_Dto_Correctly()
        {
            var antecedentesFamiliaresDto = _antecedentesFamiliaresModel.ModelToDto();

            Assert.AreEqual(antecedentesFamiliaresDto.idAFamiliares, _antecedentesFamiliaresModel.idAFamiliares);
            Assert.AreEqual(antecedentesFamiliaresDto.otros, _antecedentesFamiliaresModel.otros);
        }

        [TestMethod]
        public void AntecedentesFamiliaresDto_Maps_To_Model_CorrectType()
        {
            var antecedentesFamiliaresModel = _antecedentesFamiliaresDto.DtoToModel();

            Assert.AreEqual(typeof(AntecedentesFamiliaresModel), antecedentesFamiliaresModel.GetType());
        }

        [TestMethod]
        public void AntecedentesFamiliaresDto_Maps_To_Model_Correctly()
        {
            var antecedentesFamiliaresModel = _antecedentesFamiliaresDto.DtoToModel();

            Assert.AreEqual(antecedentesFamiliaresModel.idAFamiliares, _antecedentesFamiliaresDto.idAFamiliares);
            Assert.AreEqual(antecedentesFamiliaresModel.otros, _antecedentesFamiliaresDto.otros);
        }

    }
}
