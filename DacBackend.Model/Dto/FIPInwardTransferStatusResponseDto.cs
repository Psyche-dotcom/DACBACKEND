namespace DacBackend.Model.Dto;

public class FIPInwardTransferStatusResponseDto : BaseResponseDto
{
    public bool ReceiptSent { get; set; }
    public IEnumerable<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
}

