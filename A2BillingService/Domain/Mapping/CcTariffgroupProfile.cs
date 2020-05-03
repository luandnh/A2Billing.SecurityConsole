using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTariffgroupProfile
        : AutoMapper.Profile
    {
        public CcTariffgroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTariffgroup, A2BillingService.Domain.Models.CcTariffgroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTariffgroupCreateModel, A2BillingService.Data.Entities.CcTariffgroup>();
            CreateMap<A2BillingService.Data.Entities.CcTariffgroup, A2BillingService.Domain.Models.CcTariffgroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTariffgroupUpdateModel, A2BillingService.Data.Entities.CcTariffgroup>();
        }

    }
}
