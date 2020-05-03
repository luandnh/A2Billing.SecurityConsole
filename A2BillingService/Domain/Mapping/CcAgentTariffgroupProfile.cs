using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcAgentTariffgroupProfile
        : AutoMapper.Profile
    {
        public CcAgentTariffgroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcAgentTariffgroup, A2BillingService.Domain.Models.CcAgentTariffgroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentTariffgroupCreateModel, A2BillingService.Data.Entities.CcAgentTariffgroup>();
            CreateMap<A2BillingService.Data.Entities.CcAgentTariffgroup, A2BillingService.Domain.Models.CcAgentTariffgroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcAgentTariffgroupUpdateModel, A2BillingService.Data.Entities.CcAgentTariffgroup>();
        }

    }
}
