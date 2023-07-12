using DacBackend.Model.Dto;

namespace DipoleDacCustomerAgentBackend.Service.Interface
{
    public interface IAccountHttpService
    {
        Task<BvnResponseDto> RequestUserBvn(RequestDto bvnDto);
        Task<Object> RequestLien(RequestDto lienDto); 

    }
}
