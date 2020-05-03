using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcLogpaymentAgentProfile
        : AutoMapper.Profile
    {
        public CcLogpaymentAgentProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcLogpaymentAgent, A2BillingService.Domain.Models.CcLogpaymentAgentReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogpaymentAgentCreateModel, A2BillingService.Data.Entities.CcLogpaymentAgent>();
            CreateMap<A2BillingService.Data.Entities.CcLogpaymentAgent, A2BillingService.Domain.Models.CcLogpaymentAgentUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcLogpaymentAgentUpdateModel, A2BillingService.Data.Entities.CcLogpaymentAgent>();
        }

    }
}
