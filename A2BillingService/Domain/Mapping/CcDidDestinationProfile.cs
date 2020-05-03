using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcDidDestinationProfile
        : AutoMapper.Profile
    {
        public CcDidDestinationProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcDidDestination, A2BillingService.Domain.Models.CcDidDestinationReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidDestinationCreateModel, A2BillingService.Data.Entities.CcDidDestination>();
            CreateMap<A2BillingService.Data.Entities.CcDidDestination, A2BillingService.Domain.Models.CcDidDestinationUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidDestinationUpdateModel, A2BillingService.Data.Entities.CcDidDestination>();
        }

    }
}
