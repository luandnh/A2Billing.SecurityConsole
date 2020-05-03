using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcProviderProfile
        : AutoMapper.Profile
    {
        public CcProviderProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcProvider, A2BillingService.Domain.Models.CcProviderReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcProviderCreateModel, A2BillingService.Data.Entities.CcProvider>();
            CreateMap<A2BillingService.Data.Entities.CcProvider, A2BillingService.Domain.Models.CcProviderUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcProviderUpdateModel, A2BillingService.Data.Entities.CcProvider>();
        }

    }
}
