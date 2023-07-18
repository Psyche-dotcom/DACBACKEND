namespace DacBackend.Model.Dto;

public class LienResponseDto : BaseResponseDto
{
    public IEnumerable<LienDto> Liens { get; set; } = new List<LienDto>();
}
