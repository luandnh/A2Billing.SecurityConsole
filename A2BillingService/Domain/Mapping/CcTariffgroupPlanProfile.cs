using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTariffgroupPlanProfile
        : AutoMapper.Profile
    {
        public CcTariffgroupPlanProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTariffgroupPlan, A2BillingService.Domain.Models.CcTariffgroupPlanReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTariffgroupPlanCreateModel, A2BillingService.Data.Entities.CcTariffgroupPlan>();
            CreateMap<A2BillingService.Data.Entities.CcTariffgroupPlan, A2BillingService.Domain.Models.CcTariffgroupPlanUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTariffgroupPlanUpdateModel, A2BillingService.Data.Entities.CcTariffgroupPlan>();
        }

    }
}
