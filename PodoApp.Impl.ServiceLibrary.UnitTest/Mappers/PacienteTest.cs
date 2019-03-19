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
    public class PacienteTest
    {
        private readonly PacienteModel _pacienteModel;
        private readonly PacienteDto _pacienteDto;

        public PacienteTest()
        {
            _pacienteModel = new PacienteModel()
            {
                idPaciente = Guid.NewGuid()
            };

            _pacienteDto = new PacienteDto()
            {
                idPaciente = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void PacienteModel_Maps_To_Dto_CorrectType()
        {
            var pacienteDto = _pacienteModel.ModelToDto();
            Assert.AreEqual(typeof(PacienteDto), pacienteDto.GetType());
        }

        [TestMethod]
        public void PacienteModel_Maps_To_Dto_Correctly()
        {
            var pacienteDto = _pacienteModel.ModelToDto();

            Assert.AreEqual(_pacienteModel.idPaciente, pacienteDto.idPaciente);
        }

        [TestMethod]
        public void PacienteDto_Maps_To_Model_CorrectType()
        {
            var pacienteModel = _pacienteDto.DtoToModel();

            Assert.AreEqual(typeof(PacienteModel), pacienteModel.GetType());
        }

        [TestMethod]
        public void PacienteDto_Maps_To_Model_Correctly()
        {
            var pacienteModel = _pacienteDto.DtoToModel();

            Assert.AreEqual(_pacienteDto.idPaciente, pacienteModel.idPaciente);
        }
    }
}
