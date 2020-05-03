using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcDidgroupProfile
        : AutoMapper.Profile
    {
        public CcDidgroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcDidgroup, A2BillingService.Domain.Models.CcDidgroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidgroupCreateModel, A2BillingService.Data.Entities.CcDidgroup>();
            CreateMap<A2BillingService.Data.Entities.CcDidgroup, A2BillingService.Domain.Models.CcDidgroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidgroupUpdateModel, A2BillingService.Data.Entities.CcDidgroup>();
        }

    }
}
