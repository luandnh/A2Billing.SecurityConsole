using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCountryProfile
        : AutoMapper.Profile
    {
        public CcCountryProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCountry, A2BillingService.Domain.Models.CcCountryReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCountryCreateModel, A2BillingService.Data.Entities.CcCountry>();
            CreateMap<A2BillingService.Data.Entities.CcCountry, A2BillingService.Domain.Models.CcCountryUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCountryUpdateModel, A2BillingService.Data.Entities.CcCountry>();
        }

    }
}
