using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcEpaymentLogAgentProfile
        : AutoMapper.Profile
    {
        public CcEpaymentLogAgentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcEpaymentLogAgent, A2BillingService.Domain.Models.CcEpaymentLogAgentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcEpaymentLogAgentCreateModel, A2BillingService.Data.Entities.CcEpaymentLogAgent>();
            CreateMap<A2BillingService.Data.Entities.CcEpaymentLogAgent, A2BillingService.Domain.Models.CcEpaymentLogAgentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcEpaymentLogAgentUpdateModel, A2BillingService.Data.Entities.CcEpaymentLogAgent>();
        }

    }
}
