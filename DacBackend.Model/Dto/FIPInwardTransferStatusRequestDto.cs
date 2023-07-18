namespace DacBackend.Model.Dto;

public class FIPInwardTransferStatusRequestDto : BaseRequestDto
{
    public string AccountNumber { get; set; }
    public string TransactionDate { get; set; }
    public string Amount { get; set; }
    public string SessionId { get; set; }
    public int FIPTransferType { get; set; }
}
