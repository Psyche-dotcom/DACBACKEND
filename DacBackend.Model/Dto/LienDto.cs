namespace DacBackend.Model.Dto;

public class LienDto
{
    public string AccountNumber { get; set; }
    public string LienAmount { get; set; }
    public string LienReason { get; set; }
    public string Initiator { get; set; }
    public string Verifier { get; set; }
    public string BranchCode { get; set; }
    public DateTime LienDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}


/*
 * "AccountNumber": "3113774921",
            "LienAmount": "998700",
            "LienReason": "MASTERCARD DEBIT BLOCK FUNDS",
            "Initiator": "SYSTEM",
            "Verifier": "SYSTEM",
            "BranchCode": "111",
            "LienDate": "2019-07-12T00:00:00Z",
            "ExpiryDate": "2019-08-11T00:00:00Z" */