﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Entities
{
    internal class PaymentTransaction
    {
        public string Id { get; set; } = string.Empty;
        public string? TranMessage { get; set; } = string.Empty;
        public string? TranPayLoad { get; set; } = string.Empty;
        public string? TranStatus { get; set; } = string.Empty;
        public decimal TranAmount { get; set; }
        public DateTime? TranDate { get; set; }
        public string? PaymentId { get; set; } = string.Empty;
        public string? TranRefId { get; set;} = string.Empty;
    }
}
