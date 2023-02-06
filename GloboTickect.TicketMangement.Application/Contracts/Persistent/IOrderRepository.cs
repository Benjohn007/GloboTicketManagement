using GloboTickect.TicketMangement.Domain.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Application.Contracts.Persistent
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
 