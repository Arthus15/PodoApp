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
    public class CalzadoHabitualTest
    {
        private readonly CalzadoHabitualModel _calzadoHabitualModel;
        private readonly CalzadoHabitualDto _calzadoHabitualDto;

        public CalzadoHabitualTest()
        {
            _calzadoHabitualModel = new CalzadoHabitualModel()
            {
                idCalzado = Guid.NewGuid()
            };

            _calzadoHabitualDto = new CalzadoHabitualDto()
            {
                idCalzado = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void CalzadoHabitualModel_Maps_To_Dto_CorrectType()
        {
            var calzadoHabitualDto = _calzadoHabitualModel.ModelToDto();
            Assert.AreEqual(typeof(CalzadoHabitualDto), calzadoHabitualDto.GetType());
        }

        [TestMethod]
        public void CalzadoHabitualModel_Maps_To_Dto_Correctly()
        {
            var calzadoHabitualDto = _calzadoHabitualModel.ModelToDto();

            Assert.AreEqual(_calzadoHabitualModel.idCalzado, calzadoHabitualDto.idCalzado);
        }

        [TestMethod]
        public void CalzadoHabitualDto_Maps_To_Model_CorrectType()
        {
            var calzadoHabitualModel = _calzadoHabitualDto.DtoToModel();

            Assert.AreEqual(typeof(CalzadoHabitualModel), calzadoHabitualModel.GetType());
        }

        [TestMethod]
        public void CalzadoHabitualDto_Maps_To_Model_Correctly()
        {
            var calzadoHabitualModel = _calzadoHabitualDto.DtoToModel();

            Assert.AreEqual(_calzadoHabitualDto.idCalzado, calzadoHabitualModel.idCalzado);
        }
    }
}
