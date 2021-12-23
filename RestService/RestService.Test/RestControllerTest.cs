using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using RestService.Controllers;
using RestService.Dto;
using RestService.MapperProfile;
using RestService.Models;
using RestService.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

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
        public void Controller_ShouldPassWithValidData()
        {
            
            RequestDto request = new RequestDto();
            request.numbers = TestData.GetData();
           
            _mockBusinessLogic.Setup(xx => xx.GetSecondHighestInteger(It.IsAny<RequestModel>())).Returns(35);

            var response = _restController.GetSecondHeighestInteger(request);
            
            var okResult = response.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(okResult.StatusCode, (int)HttpStatusCode.OK);
            Assert.AreEqual(35, okResult.Value);

        }

    }
}
