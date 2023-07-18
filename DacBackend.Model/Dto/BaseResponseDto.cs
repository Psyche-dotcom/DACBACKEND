namespace DacBackend.Model.Dto
{
    public class BaseResponseDto
    {
        public string RequestId { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}