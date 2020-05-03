using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTicketProfile
        : AutoMapper.Profile
    {
        public CcTicketProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTicket, A2BillingService.Domain.Models.CcTicketReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTicketCreateModel, A2BillingService.Data.Entities.CcTicket>();
            CreateMap<A2BillingService.Data.Entities.CcTicket, A2BillingService.Domain.Models.CcTicketUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTicketUpdateModel, A2BillingService.Data.Entities.CcTicket>();
        }

    }
}
