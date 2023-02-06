using AutoMapper;
using GloboTickect.TicketMangement.Application.Features.Events;
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
            CreateMap<EventArgs, EventListVm>().ReverseMap();
        }
    }
}
