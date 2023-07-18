namespace DacBackend.Model.Dto
{
    public class OutwardTransferResponseDto : BaseResponseDto
    {
        public bool ReceiptSent { get; set; }
        public IEnumerable<TransactionDetailsDto> TransactionDetails { get; set; }
    }
}