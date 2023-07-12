using DacBackend.Model.Dto;
using DipoleDacCustomerAgentBackend.Service.Interface;

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

        public async Task<object> RequestLien(RequestDto lienDto)
        {
            var result = await _httpClient.PostAsJsonAsync("dac/account/lien", lienDto);
            var readResult = await result.Content.ReadFromJsonAsync<object>();
            return readResult;
        }

        public async Task<BvnResponseDto> RequestUserBvn(RequestDto bvnDto)
        {
            var result = await _httpClient.PostAsJsonAsync("dac/account/bvn", bvnDto);
            var readResult = await result.Content.ReadFromJsonAsync<BvnResponseDto>();
            return readResult;

        }
    }
}
