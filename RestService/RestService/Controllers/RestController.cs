using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestService.Dto;
using RestService.Models;
using RestService.Services;
using System.Linq;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestController : ControllerBase
    {

        private IBusinessLogic _businessLogic { get; }
        private readonly IMapper _mapper;
        public RestController(IBusinessLogic businessLogic, IMapper mapper)
        {
            _businessLogic = businessLogic;
            _mapper = mapper;
        }

        

        [HttpGet]
        [Route("get-second-heighest")]
        public ActionResult<int> GetSecondHeighestInteger([FromBody] RequestDto request)
        {
            var model = _mapper.Map<RequestModel>(request);
            var result = _businessLogic.GetSecondHighestInteger(model);            
            return Ok(result);
            
        }
        
    }
}
