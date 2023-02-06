using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Domain.Common
{
    public class AuditableEntity
    {

        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? LastModifieldBy { get; set; }
        public DateTime LastModifieldDate { get; set; }
    }
}
