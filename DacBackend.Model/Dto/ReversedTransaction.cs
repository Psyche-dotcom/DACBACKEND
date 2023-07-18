namespace DacBackend.Model.Dto;

public class ReversedTransaction
{
    public string TransactionId { get; set; }
    public string TransactionDate { get; set; }
    public string Amount { get; set; }
    public string Narration { get; set; }
    public string ValueDate { get; set; }
    public string? Reference { get; set; }
    public string? TransactionRemarks { get; set; }
    public string SolId { get; set; }
}