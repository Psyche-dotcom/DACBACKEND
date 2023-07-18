namespace DacBackend.Model.Dto;

public class ChargeReversalResponseDto : BaseResponseDto
{
    public string Status { get; set; }
    public IEnumerable<ReversedTransaction> ReversedTransactions { get; set; } = new List<ReversedTransaction>();
}
