namespace DacBackend.Model.Dto
{
    public class ValidateTokenRequestDto
    {
        public string Token { get; set; }
        public string UserId { get; set; }
        public string RequestId { get; set; }
    }
}