﻿using AutoMapper;
using GloboTickect.TicketMangement.Application.Contracts.Persistent;
using GloboTickect.TicketMangement.Application.features.Events;
using GloboTickect.TicketMangement.Domain.events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Application.Features.Events
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery,List<EventListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventRepository;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }
        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, 
            CancellationToken cancellationToken)
         {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
            
         }
    }
}
