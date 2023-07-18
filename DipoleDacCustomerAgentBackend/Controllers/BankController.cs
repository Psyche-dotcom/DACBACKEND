using DacBackend.Model.Dto;
using DipoleDacCustomerAgentBackend.Service.Interface;
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
        public async Task<IActionResult> RequestBvn(RequestDto requestBvnDto)
        {
            var response = await _accountHttp.RequestUserBvn(requestBvnDto);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("account/status")]
        public async Task<IActionResult> RequestAccountStatus(RequestDto requestAccountStatusDto)
        {
            var response = await _accountHttp.RequestAccountStatus(requestAccountStatusDto);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("transaction/status")]
        public async Task<IActionResult> RequestTransactionStatus(TransactionStatusRequestDto requestTransactionStatusDto)
        {
            var response = await _accountHttp.RequestTransactionStatus(requestTransactionStatusDto);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("account/get-account-details")]
        public async Task<IActionResult> RequestAccountDetails(RequestDto accountDetails)
        {
            var response = await _accountHttp.RequestAccountDetails(accountDetails);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("statement/send-statement")]
        public async Task<IActionResult> SendStatement(SendStatementRequestDto sendStatement)
        {
            var response = await _accountHttp.SendStatement(sendStatement);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("fip/outward-transfer-status")]
        public async Task<IActionResult> OutwardTransfer(OutWardTransferRequestDto outwardTransfer)
        {
            var response = await _accountHttp.RequestOutwardTransfer(outwardTransfer);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("token/validate")]
        public async Task<IActionResult> ValidateToken(ValidateTokenRequestDto validateToken)
        {
            var response = await _accountHttp.RequestValidateToken(validateToken);
            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}