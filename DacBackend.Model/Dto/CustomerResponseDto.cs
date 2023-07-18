namespace DacBackend.Model.Dto;

public class CustomerResponseDto : BaseResponseDto
{
    public int CustomerId { get; set; }
    public string Title { get; set; }
    public string Gender { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string CustomerCategory { get; set; }
    public string Address { get; set; }
    public string DateOfBirth { get; set; }
    public string MobileNo { get; set; }
    public string Email { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}