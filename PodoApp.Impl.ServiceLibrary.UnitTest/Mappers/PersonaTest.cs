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
    public class PersonaTest
    {
        private readonly PersonaModel _personaModel;
        private readonly PersonaDto _personaDto;

        public PersonaTest()
        {
            _personaDto = new PersonaDto()
            {
                idPersona = Guid.NewGuid()
            };

            _personaModel = new PersonaModel()
            {
                idPersona = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void PersonaModel_Maps_To_Dto_CorrectType()
        {
            var personaDto = _personaModel.ModelToDto();
            Assert.AreEqual(typeof(PersonaDto), personaDto.GetType());
        }

        [TestMethod]
        public void PersonaModel_Maps_To_Dto_Correctly()
        {
            var personaDto = _personaModel.ModelToDto();

            Assert.AreEqual(_personaModel.idPersona, personaDto.idPersona);
        }

        [TestMethod]
        public void PersonaDto_Maps_To_Model_CorrectType()
        {
            var personaModel = _personaDto.DtoToModel();

            Assert.AreEqual(typeof(PersonaModel), personaModel.GetType());
        }

        [TestMethod]
        public void PersonaDto_Maps_To_Model_Correctly()
        {
            var personaModel = _personaDto.DtoToModel();

            Assert.AreEqual(_personaDto.idPersona, personaModel.idPersona);
        }
    }
}
