namespace DacBackend.Model.Dto
{
    public class TransactionStatusResponseDto : BaseResponseDto
    {
        public string FinacleTranId { get; set; }
        public string TransactionReference { get; set; }
        public string TransactionStatus { get; set; }
    }
}