using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCallplanLcrProfile
        : AutoMapper.Profile
    {
        public CcCallplanLcrProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCallplanLcr, A2BillingService.Domain.Models.CcCallplanLcrReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallplanLcrCreateModel, A2BillingService.Data.Entities.CcCallplanLcr>();
            CreateMap<A2BillingService.Data.Entities.CcCallplanLcr, A2BillingService.Domain.Models.CcCallplanLcrUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCallplanLcrUpdateModel, A2BillingService.Data.Entities.CcCallplanLcr>();
        }

    }
}
