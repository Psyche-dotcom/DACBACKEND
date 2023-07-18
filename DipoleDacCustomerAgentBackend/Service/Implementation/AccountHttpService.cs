using DacBackend.Model.Dto;
using DipoleDacCustomerAgentBackend.Service.Interface;
using System.Text;
using System.Text.Json;

namespace DipoleDacCustomerAgentBackend.Service.Implementation
{
    public class AccountHttpService : IAccountHttpService
    {
        private readonly HttpClient _httpClient;

        public AccountHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("AppId", "DAC1234567890");
            _httpClient.DefaultRequestHeaders.Add("AppKey", "DAC");
        }

        public async Task<AccountDetailsResponseDto> RequestAccountDetails(RequestDto accountdetails)
        {
            var jsonToSend = JsonSerializer.Serialize(accountdetails);
            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/account/get-account-details", content);
            var readResult = await result.Content.ReadFromJsonAsync<AccountDetailsResponseDto>();
            return readResult;
        }

        public async Task<RequestAccountStatusResponseDto> RequestAccountStatus(RequestDto accountstatus)
        {
            var jsonToSend = JsonSerializer.Serialize(accountstatus);
            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/account/status", content);
            var readResult = await result.Content.ReadFromJsonAsync<RequestAccountStatusResponseDto>();
            return readResult;
        }

        public async Task<OutwardTransferResponseDto> RequestOutwardTransfer(OutWardTransferRequestDto outwardtransfer)
        {
            var jsonToSend = JsonSerializer.Serialize(outwardtransfer);
            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/fip/outward-transfer-status", content);
            var readResult = await result.Content.ReadFromJsonAsync<OutwardTransferResponseDto>();
            return readResult;
        }

        public async Task<TransactionStatusResponseDto> RequestTransactionStatus(TransactionStatusRequestDto transactionstatus)
        {
            var jsonToSend = JsonSerializer.Serialize(transactionstatus);

            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/transaction/status", content);
            var readResult = await result.Content.ReadFromJsonAsync<TransactionStatusResponseDto>();
            return readResult;
        }

        public async Task<BvnResponseDto> RequestUserBvn(RequestDto bvnDto)
        {
            var jsonToSend = JsonSerializer.Serialize(bvnDto);
            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/account/bvn", content);
            var readResult = await result.Content.ReadFromJsonAsync<BvnResponseDto>();
            return readResult;
        }

        public async Task<ValidateTokenResponseDto> RequestValidateToken(ValidateTokenRequestDto validatetoken)
        {
            var jsonToSend = JsonSerializer.Serialize(validatetoken);
            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/token/validate", content);
            var readResult = await result.Content.ReadFromJsonAsync<ValidateTokenResponseDto>();
            return readResult;
        }

        public async Task<BaseResponseDto> SendStatement(SendStatementRequestDto statement)
        {
            var jsonToSend = JsonSerializer.Serialize(statement);
            var content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("dac/statement/send-statement", content);
            var readResult = await result.Content.ReadFromJsonAsync<BaseResponseDto>();
            return readResult;
        }
    }
}