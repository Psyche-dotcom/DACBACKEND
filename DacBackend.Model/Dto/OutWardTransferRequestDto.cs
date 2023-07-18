namespace DacBackend.Model.Dto
{
    public class OutWardTransferRequestDto : RequestDto
    {
        public string TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string SessionId { get; set; }
        public int FIPTransferType { get; set; }
    }
}