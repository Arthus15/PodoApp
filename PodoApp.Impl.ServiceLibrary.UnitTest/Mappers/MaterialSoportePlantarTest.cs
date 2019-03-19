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
    public class MaterialSoportePlantarTest
    {
        private readonly MaterialSoportePlantarModel _materialSoportePlantarModel;
        private readonly MaterialSoportePlantarDto _materialSoportePlantarDto;

        public MaterialSoportePlantarTest()
        {
            _materialSoportePlantarDto = new MaterialSoportePlantarDto()
            {
                idMaterialSoportePlantar = Guid.NewGuid()
            };

            _materialSoportePlantarModel = new MaterialSoportePlantarModel()
            {
                idMaterialSoportePlantar = Guid.NewGuid()
            };
        }

        [TestMethod]
        public void MaterialSoportePlantarModel_Maps_To_Dto_CorrectType()
        {
            var materialSoportePlantarDto = _materialSoportePlantarModel.ModelToDto();
            Assert.AreEqual(typeof(MaterialSoportePlantarDto), materialSoportePlantarDto.GetType());
        }

        [TestMethod]
        public void MaterialSoportePlantarModel_Maps_To_Dto_Correctly()
        {
            var materialSoportePlantarDto = _materialSoportePlantarModel.ModelToDto();

            Assert.AreEqual(_materialSoportePlantarModel.idMaterialSoportePlantar, materialSoportePlantarDto.idMaterialSoportePlantar);
        }

        [TestMethod]
        public void MaterialSoportePlantarDto_Maps_To_Model_CorrectType()
        {
            var materialSoportePlantarModel = _materialSoportePlantarDto.DtoToModel();

            Assert.AreEqual(typeof(MaterialSoportePlantarModel), materialSoportePlantarModel.GetType());
        }

        [TestMethod]
        public void MaterialSoportePlantarDto_Maps_To_Model_Correctly()
        {
            var materialSoportePlantarModel = _materialSoportePlantarDto.DtoToModel();

            Assert.AreEqual(_materialSoportePlantarDto.idMaterialSoportePlantar, materialSoportePlantarModel.idMaterialSoportePlantar);
        }
    }
}
