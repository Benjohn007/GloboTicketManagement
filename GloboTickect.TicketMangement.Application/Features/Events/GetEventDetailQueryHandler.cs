using AutoMapper;
using GloboTickect.TicketMangement.Application.Contracts.Persistent;
using GloboTickect.TicketMangement.Domain.events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Application.Features.Events
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;

        public GetEventDetailQueryHandler(IMapper mapper, 
            IAsyncRepository<Event> eventRepository, IAsyncRepository<Category> categoryRepository) 
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<EventDetailVm> Handle(GetEventDetailQuery requset,
            CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(requset.Id);
            var eventDetailDto = _mapper.Map<EventDetailVm>(@event);

            var category = await _categoryRepository.GetByIdAsync(requset.Id);
            
            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return eventDetailDto;
        }
    }
}
