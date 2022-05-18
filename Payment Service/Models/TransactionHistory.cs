using System.ComponentModel.DataAnnotations;

namespace Payment_Service.Models
{
    public class TransactionHistory
    {
        [Key]
        public string Name { get; set; }

        public TransactionPowerApps Transaction { get; set; }

        public string Result { get; set; }

        public string Message { get; set; }
    }
}
