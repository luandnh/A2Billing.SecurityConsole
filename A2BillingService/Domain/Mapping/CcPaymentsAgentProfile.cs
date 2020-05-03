using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPaymentsAgentProfile
        : AutoMapper.Profile
    {
        public CcPaymentsAgentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPaymentsAgent, A2BillingService.Domain.Models.CcPaymentsAgentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentsAgentCreateModel, A2BillingService.Data.Entities.CcPaymentsAgent>();
            CreateMap<A2BillingService.Data.Entities.CcPaymentsAgent, A2BillingService.Domain.Models.CcPaymentsAgentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPaymentsAgentUpdateModel, A2BillingService.Data.Entities.CcPaymentsAgent>();
        }

    }
}
