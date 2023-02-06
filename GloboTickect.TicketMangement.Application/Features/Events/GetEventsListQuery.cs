using GloboTickect.TicketMangement.Application.Features.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Application.features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
