using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAgentProfile
        : AutoMapper.Profile
    {
        public CcAgentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAgent, A2BillingService.Domain.Models.CcAgentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentCreateModel, A2BillingService.Data.Entities.CcAgent>();
            CreateMap<A2BillingService.Data.Entities.CcAgent, A2BillingService.Domain.Models.CcAgentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentUpdateModel, A2BillingService.Data.Entities.CcAgent>();
        }

    }
}
