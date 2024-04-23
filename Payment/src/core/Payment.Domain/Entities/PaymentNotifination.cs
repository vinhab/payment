using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Entities
{
    internal class PaymentNotifination
    {
        public string Id { get; set; } = string.Empty;
        public string? PaymentRefId { get; set; } = string.Empty;
        public DateTime? NotiDate { get; set; }
        public string? NotiAmount { get; set; } = string.Empty;
        public string? NotiContent { get; set; } = string.Empty;
        public string? NotiMessage { get; set; } = string.Empty;
        public string? NotiSignature { get; set; } = string.Empty;
        public string? PaymentId { get; set; } = string.Empty;
        public string? MerchantId { get; set; } = string.Empty;
        public string? NotiSatus { get; set; } = string.Empty;
        public DateTime? NotiResDate { get; set; }
        public string? NotiResMessage { get;set; } = string.Empty;
        public string? NotiResHttpCode { get; set; } = string.Empty;

    }
}
