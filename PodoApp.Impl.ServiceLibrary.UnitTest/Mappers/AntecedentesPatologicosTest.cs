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
    public class AntecedentesPatologicosTest
    {
        private readonly AntecedentesPatologicosDto _antecedentesPatologicosDto;
        private readonly AntecedentesPatologicosModel _antecedentesPatologicosModel;

        public AntecedentesPatologicosTest()
        {
            _antecedentesPatologicosDto = new AntecedentesPatologicosDto()
            {
                idAPatologico = Guid.NewGuid()
            };

            _antecedentesPatologicosModel = new AntecedentesPatologicosModel()
            {
                idAPatologico = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void AntecedentesPatologicosModel_Maps_To_Dto_CorrectType()
        {
            var antecedentesPatologicosDto = _antecedentesPatologicosModel.ModelToDto();
            Assert.AreEqual(typeof(AntecedentesPatologicosDto), antecedentesPatologicosDto.GetType());
        }

        [TestMethod]
        public void AntecedentesPatologicosModel_Maps_To_Dto_Correctly()
        {
            var antecedentesPatologicosDto = _antecedentesPatologicosModel.ModelToDto();

            Assert.AreEqual(_antecedentesPatologicosModel.idAPatologico, antecedentesPatologicosDto.idAPatologico);
        }

        [TestMethod]
        public void AntecedentesPatologicosDto_Maps_To_Model_CorrectType()
        {
            var antecedentesPatologicosModel = _antecedentesPatologicosDto.DtoToModel();

            Assert.AreEqual(typeof(AntecedentesPatologicosModel), antecedentesPatologicosModel.GetType());
        }

        [TestMethod]
        public void AntecedentesPatologicosDto_Maps_To_Model_Correctly()
        {
            var antecedentesPatologicosModel = _antecedentesPatologicosDto.DtoToModel();

            Assert.AreEqual(_antecedentesPatologicosDto.idAPatologico, antecedentesPatologicosModel.idAPatologico);
        }

    }
}
