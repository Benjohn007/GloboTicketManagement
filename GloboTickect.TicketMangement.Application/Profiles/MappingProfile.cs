using AutoMapper;
using GloboTickect.TicketMangement.Application.Features.Events;
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

        }
    }
}
