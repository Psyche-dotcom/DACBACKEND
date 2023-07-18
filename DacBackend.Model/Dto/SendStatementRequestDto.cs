namespace DacBackend.Model.Dto
{
    public class SendStatementRequestDto : RequestDto
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}