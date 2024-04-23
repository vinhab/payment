using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Entities
{
    internal class PaymentDestination
    {
        public string Id { get; set; } = string.Empty;
        public string? DesLogo { get; set; } = string.Empty;
        public string? DesShortName { get; set; } = string.Empty;
        public string? DesName { get; set; } = string.Empty;
        public int DesSortIndex { get; set; } = 0;
        public string? ParentId { get; set;} = string.Empty;
        public bool IsActive { get; set; }


    }
}
