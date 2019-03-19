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
    public class PrimeraVisitaTest
    {
        private readonly PrimeraVisitaModel _primeraVisitaModel;
        private readonly PrimeraVisitaDto _primeraVisitaDto;

        public PrimeraVisitaTest()
        {
            _primeraVisitaDto = new PrimeraVisitaDto()
            {
                idPrimeraVisita = Guid.NewGuid()
            };

            _primeraVisitaModel = new PrimeraVisitaModel()
            {
                idPrimeraVisita = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void PrimeraVisitaModel_Maps_To_Dto_CorrectType()
        {
            var primeraVisitaDto = _primeraVisitaModel.ModelToDto();
            Assert.AreEqual(typeof(PrimeraVisitaDto), primeraVisitaDto.GetType());
        }

        [TestMethod]
        public void PrimeraVisitaModel_Maps_To_Dto_Correctly()
        {
            var primeraVisitaDto = _primeraVisitaModel.ModelToDto();

            Assert.AreEqual(_primeraVisitaModel.idPrimeraVisita, primeraVisitaDto.idPrimeraVisita);
        }

        [TestMethod]
        public void PrimeraVisitaDto_Maps_To_Model_CorrectType()
        {
            var primeraVisitaModel = _primeraVisitaDto.DtoToModel();

            Assert.AreEqual(typeof(PrimeraVisitaModel), primeraVisitaModel.GetType());
        }

        [TestMethod]
        public void PrimeraVisitaDto_Maps_To_Model_Correctly()
        {
            var primeraVisitaModel = _primeraVisitaDto.DtoToModel();

            Assert.AreEqual(_primeraVisitaDto.idPrimeraVisita, primeraVisitaModel.idPrimeraVisita);
        }
    }
}
