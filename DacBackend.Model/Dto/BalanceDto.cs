namespace DacBackend.Model.Dto;

public class BalanceDto : BaseResponseDto
{
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public string AvailableBalance { get; set; }
}
