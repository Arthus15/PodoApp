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
    public class PodologoTest
    {
        private readonly PodologoModel _podologoModel;
        private readonly PodologoDto _podologoDto;

        public PodologoTest()
        {
            _podologoModel = new PodologoModel()
            {
                idPodologo = Guid.NewGuid()
            };

            _podologoDto = new PodologoDto()
            {
                idPodologo = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void PodologoModel_Maps_To_Dto_CorrectType()
        {
            var podologoDto = _podologoModel.ModelToDto();
            Assert.AreEqual(typeof(PodologoDto), podologoDto.GetType());
        }

        [TestMethod]
        public void PodologoModel_Maps_To_Dto_Correctly()
        {
            var podologoDto = _podologoModel.ModelToDto();

            Assert.AreEqual(_podologoModel.idPodologo, podologoDto.idPodologo);
        }
    }
}
