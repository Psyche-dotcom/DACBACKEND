using DacBackend.Model.Dto;
using DipoleDacCustomerAgentBackend.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DipoleDacCustomerAgentBackend.Controllers
{
    [Route("api/bank/dac")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IAccountHttpService _accountHttp;

        public BankController(IAccountHttpService accountHttp)
        {
            _accountHttp = accountHttp;
        }
        [HttpPost("bvn")]
        public async Task<IActionResult> RequestBvn( RequestDto requestBvnDto)
        {
            var response = await _accountHttp.RequestUserBvn(requestBvnDto);
            if(response.ResponseCode== 00 )
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpPost("lien")]
        public async Task<IActionResult> RequestLien(RequestDto requestBvnDto)
        {
            var response = await _accountHttp.RequestLien(requestBvnDto);
           
                return Ok(response);
            
           
        }
    }
}
