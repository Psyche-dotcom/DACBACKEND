namespace DacBackend.Model.Dto
{
    public class TransactionDetailsDto
    {
        public Decimal Amount { get; set; }
        public string TransactionDate { get; set; }
        public string Narration { get; set; }
        public string SessionID { get; set; }
        public string Status { get; set; }
        public string BeneficiaryAccount { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryBankName { get; set; }
        public string BeneficiaryBankCode { get; set; }
        public string OriginatorNumber { get; set; }
        public string OriginatorName { get; set; }
    }
}