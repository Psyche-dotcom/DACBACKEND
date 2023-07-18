namespace DacBackend.Model.Dto
{
    public class AccountDetailsResponseDto : BaseResponseDto
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string ProductCode { get; set; }
        public string Product { get; set; }
        public string AccountStatus { get; set; }
        public string CurrencyCode { get; set; }
        public string BranchCode { get; set; }
        public string Branch { get; set; }
        public decimal BookBalance { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal LienAmount { get; set; }
        public decimal UnclearedBalance { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string RelationshipManagerId { get; set; }
        public IEnumerable<TransactionDto> LastNTransactions { get; set; }
    }
}