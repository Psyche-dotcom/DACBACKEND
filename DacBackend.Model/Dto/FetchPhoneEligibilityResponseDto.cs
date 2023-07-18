namespace DacBackend.Model.Dto;

public class FetchPhoneEligibilityResponseDto : BaseResponseDto
{
    public string Amount { get; set; }
    public DateTime LastSalaryDate { get; set; }
    public string AvgSalaryPerYear { get; set; }
    public string LastSalaryAmount { get; set; }
    public string Currency { get; set; }
    public string Status { get; set; }

}