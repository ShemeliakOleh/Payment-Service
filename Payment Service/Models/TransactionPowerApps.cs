namespace Payment_Service.Models
{
    public class TransactionPowerApps
    {
        public string Id { get; set; }
        public string CreaditCardId { get; set; }
        public double Amount { get; set; }
        public string TerminalId { get; set; }
        public string TransactionType { get; set; }
        public bool Completed { get; set; }

    }
}
