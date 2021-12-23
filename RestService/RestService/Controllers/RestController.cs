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


        /// <summary>
        /// Take request from request body and returns second heighest number
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-second-heighest")]
        public ActionResult<int> GetSecondHeighestInteger([FromBody] RequestDto request)
        {
            
            if(request.numbers.Any())
            {
                if(request.numbers.ToList().Count > 1)
                {
                    var model = _mapper.Map<RequestModel>(request);
                    var result = _businessLogic.GetSecondHighestInteger(model);
                    
                    return Ok(result);
                }
               else
                {
                    return BadRequest("Error: Please provide atleast 2 numbers in array");
                }
            }
            else
            {
                return BadRequest("Error: Data is not valid");
            }
            
        }
        
    }
}
