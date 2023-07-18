namespace DacBackend.Model.Dto
{
    public class TransactionDto
    {
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public string Currency { get; set; }
        public string TransactionDate { get; set; }
        public string Remarks { get; set; }
    }
}