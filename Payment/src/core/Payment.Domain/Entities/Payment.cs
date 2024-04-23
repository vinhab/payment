﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Entities
{
    internal class Payment
    {
        public string PaymentId { get; set; } = string.Empty;
        public string? PaymentContent { get; set; } = string.Empty;
        public string? PaymentCurrecy {  get; set; } = string.Empty;
        public string? PaymentRefId { get; set; } = string.Empty;
        public decimal? RequireAmount { get; set; }
        public DateTime? PaymentDate { get; set; } = DateTime.Now;
        public DateTime? ExpireDate { get; set; }
        public string? PaymentLanguage { get; set; } = string.Empty;
        public string? MerchantId { get; set; } = string.Empty;
        public string? PaymentDestinationId { get; set; } = string.Empty;
        public decimal PaidAmount { get; set; }
        public string? PaymentStatus { get; set; } = string.Empty;
        public string? PaymentLastMessage { get; set; } = string.Empty;
    }
}
