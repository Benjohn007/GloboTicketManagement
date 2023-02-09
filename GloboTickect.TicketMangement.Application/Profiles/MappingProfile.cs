using AutoMapper;
using GloboTickect.TicketMangement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTickect.TicketMangement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTickect.TicketMangement.Application.Features.Events.Commands.CreateEvent;
using GloboTickect.TicketMangement.Application.Features.Events.Commands.DeleteEvent;
using GloboTickect.TicketMangement.Application.Features.Events.Commands.UpdateEvent;
using GloboTickect.TicketMangement.Application.Features.Events.GetEventDetail;
using GloboTickect.TicketMangement.Application.Features.Events.GetEventsList;
using GloboTickect.TicketMangement.Domain.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTickect.TicketMangement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, DeleteEventCommand>().ReverseMap();

        }
    }
}
