namespace DacBackend.Model.Dto;

public class GetAccountsWithMobileResponse : BaseResponseDto
{
    public IEnumerable<string> Accounts { get; set; } = new List<string>();
}
