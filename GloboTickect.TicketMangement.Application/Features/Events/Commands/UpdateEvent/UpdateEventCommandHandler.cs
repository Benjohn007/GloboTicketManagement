using AutoMapper;
using GloboTickect.TicketMangement.Application.Contracts.Persistent;
using GloboTickect.TicketMangement.Domain.events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequest<UpdateEventCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventRepository;

        public UpdateEventCommandHandler(IMapper mapper, IAsyncRepository<Event> 
            eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken
            cancellationToken)
        {
            var eventToUpdate = await _eventRepository.GetByIdAsync(request.EventId);

            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand),
                typeof(Event));

            await _eventRepository.UpdateAsync(eventToUpdate);
            return Unit.Value;
        }
    }
}
