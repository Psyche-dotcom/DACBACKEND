using DacBackend.Model.Dto;

namespace DipoleDacCustomerAgentBackend.Service.Interface
{
    public interface IAccountHttpService
    {
        Task<BvnResponseDto> RequestUserBvn(RequestDto bvnDto);

        Task<RequestAccountStatusResponseDto> RequestAccountStatus(RequestDto accountstatus);

        Task<BaseResponseDto> SendStatement(SendStatementRequestDto statement);

        Task<AccountDetailsResponseDto> RequestAccountDetails(RequestDto accountdetails);

        Task<OutwardTransferResponseDto> RequestOutwardTransfer(OutWardTransferRequestDto outwardtransfer);

        Task<TransactionStatusResponseDto> RequestTransactionStatus(TransactionStatusRequestDto transactionstatus);

        Task<ValidateTokenResponseDto> RequestValidateToken(ValidateTokenRequestDto validatetoken);

        Task<LienResponseDto> RequestLien(RequestDto lienDto);
        Task<BalanceDto> BalanceEnquiry(RequestDto balanceDto);
        Task<GetAccountsWithMobileResponse> GetAccountsWithMobile(RequestWithMobileNumberDto balanceDto);
        Task<CustomerResponseDto> GetCustomerDetails(RequestCustomerDetailDto customerDetailDto);
        Task<FetchPhoneEligibilityResponseDto> FetchLoanEligibility(FetchPhoneEligibilityRequestDto request);
        Task<FIPInwardTransferStatusResponseDto> FipInwardTransferStatus(FIPInwardTransferStatusRequestDto request);
        Task<ChargeReversalResponseDto> ChargeReversal(ChargeReversalRequestDto request);
    }
}