using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcMessageAgentProfile
        : AutoMapper.Profile
    {
        public CcMessageAgentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcMessageAgent, A2BillingService.Domain.Models.CcMessageAgentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcMessageAgentCreateModel, A2BillingService.Data.Entities.CcMessageAgent>();
            CreateMap<A2BillingService.Data.Entities.CcMessageAgent, A2BillingService.Domain.Models.CcMessageAgentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcMessageAgentUpdateModel, A2BillingService.Data.Entities.CcMessageAgent>();
        }

    }
}
