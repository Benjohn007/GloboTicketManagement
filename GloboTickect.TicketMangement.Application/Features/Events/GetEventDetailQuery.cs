﻿using MediatR;
 
namespace GloboTickect.TicketMangement.Application.Features.Events
{
    public class GetEventDetailQuery: IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
