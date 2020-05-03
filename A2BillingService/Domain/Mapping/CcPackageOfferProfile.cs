using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPackageOfferProfile
        : AutoMapper.Profile
    {
        public CcPackageOfferProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPackageOffer, A2BillingService.Domain.Models.CcPackageOfferReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackageOfferCreateModel, A2BillingService.Data.Entities.CcPackageOffer>();
            CreateMap<A2BillingService.Data.Entities.CcPackageOffer, A2BillingService.Domain.Models.CcPackageOfferUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackageOfferUpdateModel, A2BillingService.Data.Entities.CcPackageOffer>();
        }

    }
}
