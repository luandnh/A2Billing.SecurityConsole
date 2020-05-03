using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcConfigProfile
        : AutoMapper.Profile
    {
        public CcConfigProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcConfig, A2BillingService.Domain.Models.CcConfigReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcConfigCreateModel, A2BillingService.Data.Entities.CcConfig>();
            CreateMap<A2BillingService.Data.Entities.CcConfig, A2BillingService.Domain.Models.CcConfigUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcConfigUpdateModel, A2BillingService.Data.Entities.CcConfig>();
        }

    }
}
