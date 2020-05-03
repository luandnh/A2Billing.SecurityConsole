using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAgentCommissionProfile
        : AutoMapper.Profile
    {
        public CcAgentCommissionProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAgentCommission, A2BillingService.Domain.Models.CcAgentCommissionReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentCommissionCreateModel, A2BillingService.Data.Entities.CcAgentCommission>();
            CreateMap<A2BillingService.Data.Entities.CcAgentCommission, A2BillingService.Domain.Models.CcAgentCommissionUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentCommissionUpdateModel, A2BillingService.Data.Entities.CcAgentCommission>();
        }

    }
}
