using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardPackageOfferProfile
        : AutoMapper.Profile
    {
        public CcCardPackageOfferProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardPackageOffer, A2BillingService.Domain.Models.CcCardPackageOfferReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardPackageOfferCreateModel, A2BillingService.Data.Entities.CcCardPackageOffer>();
            CreateMap<A2BillingService.Data.Entities.CcCardPackageOffer, A2BillingService.Domain.Models.CcCardPackageOfferUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardPackageOfferUpdateModel, A2BillingService.Data.Entities.CcCardPackageOffer>();
        }

    }
}
