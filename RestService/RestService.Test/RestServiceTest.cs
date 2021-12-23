using NUnit.Framework;
using RestService.Models;
using RestService.Services;

namespace RestService.Test
{
    [TestFixture]
    public class RestServiceTest
    {
        private readonly IBusinessLogic _businessLogic;

        public RestServiceTest()
        {
            _businessLogic = new BusinessLogic();
        }
        [Test]
        public void Service_ShouldPassWithValidInputData()
        {
            // Arrange
           
            var model = new RequestModel()
            {
                Data = TestData.GetData()
             };

            //Act
            var result = _businessLogic.GetSecondHighestInteger(model);

            //Assert
            Assert.AreEqual(35, result);
        }

        
    }
}
