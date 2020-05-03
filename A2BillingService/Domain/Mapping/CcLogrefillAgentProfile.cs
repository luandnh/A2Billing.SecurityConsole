using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcLogrefillAgentProfile
        : AutoMapper.Profile
    {
        public CcLogrefillAgentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcLogrefillAgent, A2BillingService.Domain.Models.CcLogrefillAgentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogrefillAgentCreateModel, A2BillingService.Data.Entities.CcLogrefillAgent>();
            CreateMap<A2BillingService.Data.Entities.CcLogrefillAgent, A2BillingService.Domain.Models.CcLogrefillAgentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogrefillAgentUpdateModel, A2BillingService.Data.Entities.CcLogrefillAgent>();
        }

    }
}
