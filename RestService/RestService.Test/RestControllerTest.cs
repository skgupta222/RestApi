using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using RestService.Controllers;
using RestService.Dto;
using RestService.Models;
using RestService.Services;
using System.Net;

namespace RestService.Test
{
    [TestFixture]
    public class RestControllerTest
    {
        private readonly Mock<IBusinessLogic> _mockBusinessLogic;
        private readonly Mock<IMapper> _mapper;
        private readonly RestController _restController;
        
        public RestControllerTest()
        {
            _mockBusinessLogic = new Mock<IBusinessLogic>();
            _mapper = new Mock<IMapper>();
            _restController = new RestController(_mockBusinessLogic.Object, _mapper.Object);
        }
        [Test]
        public void Controller_ShouldPassWithValidData_VerfyResponseIsNotNull()
        {

            RequestDto request = new RequestDto();
            request.numbers = TestData.GetData();

            _mockBusinessLogic.Setup(xx => xx.GetSecondHighestInteger(It.IsAny<RequestModel>())).Returns(35);

            var response = _restController.GetSecondHeighestInteger(request);

            var okResult = response.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
        }

        [Test]
        public void Controller_ShouldPassWithValidData_VerfyStatusCode200()
        {
            
            RequestDto request = new RequestDto();
            request.numbers = TestData.GetData();
           
            _mockBusinessLogic.Setup(xx => xx.GetSecondHighestInteger(It.IsAny<RequestModel>())).Returns(35);

            var response = _restController.GetSecondHeighestInteger(request);
            
            var okResult = response.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(okResult.StatusCode, (int)HttpStatusCode.OK);
        }

        [Test]
        public void Controller_ShouldPassWithValidData_VerifySecondHeighestNumber()
        {

            RequestDto request = new RequestDto();
            request.numbers = TestData.GetData();

            _mockBusinessLogic.Setup(xx => xx.GetSecondHighestInteger(It.IsAny<RequestModel>())).Returns(35);

            var response = _restController.GetSecondHeighestInteger(request);

            var okResult = response.Result as OkObjectResult;
            Assert.AreEqual(35, okResult.Value);

        }
    }
}
