namespace Payment_Service.Models
{
    public class TransactionResult
    {
        public bool IsSuccessfulProcess { get; set; } = true;
        public string ErrorMessage { get; set; } = "Ok";
    }
}
