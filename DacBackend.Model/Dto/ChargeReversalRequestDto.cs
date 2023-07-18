namespace DacBackend.Model.Dto;

public class ChargeReversalRequestDto : BaseRequestDto
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string AccountNumber { get; set; }
    public string Amount { get; set; }
}

