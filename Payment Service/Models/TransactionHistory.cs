namespace Payment_Service.Models
{
    public class TransactionHistory
    {
        public Guid Id { get; set; }

        public Transaction Transaction { get; set; }

        public string TransactionType { get; set; }

        public string Result { get; set; }

        public string Message { get; set; }

        public JsonContent ResultJson { get; set; }

        public double Amount { get; set; }
    }
}
