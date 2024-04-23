using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Entities
{
    internal class PaymentSignature
    {
        public string Id { get; set; } = string.Empty;
        public string? SignValued { get; set; } = string.Empty;
        public string? SignAlgo { get; set; } = string.Empty;
        public DateTime? SignDate { get; set; }
        public string? SighOwn { get; set; } = string.Empty;
        public string? PaymentId { get; set; } = string.Empty;

        public bool IsValid {  get; set; }
    }
}
