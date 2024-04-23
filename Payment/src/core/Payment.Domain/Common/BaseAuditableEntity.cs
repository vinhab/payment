using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Common
{
    public class BaseAuditableEntity
    {
        public string? CreatedBy { get; set; } = string.Empty;
        public DateTime? DateAt { get; set; }
        public string? LastUpdateBy { get; set; } = string.Empty ;
        public DateTime? LastUpdatedAt { get; set; }

    }
}
