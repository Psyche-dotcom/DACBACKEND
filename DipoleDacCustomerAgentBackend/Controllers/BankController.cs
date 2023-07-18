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

        [HttpPost("lien")]
        public async Task<IActionResult> RequestLien(RequestDto requestBvnDto)
        {
            var response = await _accountHttp.RequestLien(requestBvnDto);

            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("balance")]
        public async Task<IActionResult> BalanceEnquiry(RequestDto request)
        {
            var response = await _accountHttp.BalanceEnquiry(request);

            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("get-accounts-with-mobile")]
        public async Task<IActionResult> GetAccountsWithMobile(RequestWithMobileNumberDto request)
        {
            var response = await _accountHttp.GetAccountsWithMobile(request);

            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("get-customer-details")]
        public async Task<IActionResult> GetCustomerDetails(RequestCustomerDetailDto request)
        {
            var response = await _accountHttp.GetCustomerDetails(request);

            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("fetch-eligibility")]
        public async Task<IActionResult> FetchLoanEligibility(FetchPhoneEligibilityRequestDto request)
        {
            var response = await _accountHttp.FetchLoanEligibility(request);

            return Ok(response);
        }

        [HttpPost("inward-transfer-status")]
        public async Task<IActionResult> FipInwardTransferStatus(FIPInwardTransferStatusRequestDto request)
        {
            var response = await _accountHttp.FipInwardTransferStatus(request);

            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("charge-reversal")]
        public async Task<IActionResult> ChargeReversal(ChargeReversalRequestDto request)
        {
            var response = await _accountHttp.ChargeReversal(request);

            if (response.ResponseCode == 00)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}