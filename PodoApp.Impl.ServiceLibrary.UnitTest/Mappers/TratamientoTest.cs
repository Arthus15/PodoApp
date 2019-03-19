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
    public class TratamientoTest
    {
        private readonly TratamientoModel _tratamientoModel;
        private readonly TratamientoDto _tratamientoDto;

        public TratamientoTest()
        {
            _tratamientoDto = new TratamientoDto()
            {
                idTratamiento = Guid.NewGuid()
            };

            _tratamientoModel = new TratamientoModel()
            {
                idTratamiento = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void TratamientoModel_Maps_To_Dto_CorrectType()
        {
            var tratamientoDto = _tratamientoModel.ModelToDto();
            Assert.AreEqual(typeof(TratamientoDto), tratamientoDto.GetType());
        }

        [TestMethod]
        public void TratamientoModel_Maps_To_Dto_Correctly()
        {
            var tratamientoDto = _tratamientoModel.ModelToDto();

            Assert.AreEqual(_tratamientoModel.idTratamiento, tratamientoDto.idTratamiento);
        }

        [TestMethod]
        public void TratamientoDto_Maps_To_Model_CorrectType()
        {
            var tratamientoModel = _tratamientoDto.DtoToModel();

            Assert.AreEqual(typeof(TratamientoModel), tratamientoModel.GetType());
        }

        [TestMethod]
        public void TratamientoDto_Maps_To_Model_Correctly()
        {
            var tratamientoModel = _tratamientoDto.DtoToModel();

            Assert.AreEqual(_tratamientoDto.idTratamiento, tratamientoModel.idTratamiento);
        }
    }
}
