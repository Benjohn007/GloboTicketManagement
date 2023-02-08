using MediatR;

namespace GloboTickect.TicketMangement.Application.Features.Events.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
