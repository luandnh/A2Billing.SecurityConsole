using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCurrenciesProfile
        : AutoMapper.Profile
    {
        public CcCurrenciesProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCurrencies, A2BillingService.Domain.Models.CcCurrenciesReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCurrenciesCreateModel, A2BillingService.Data.Entities.CcCurrencies>();
            CreateMap<A2BillingService.Data.Entities.CcCurrencies, A2BillingService.Domain.Models.CcCurrenciesUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCurrenciesUpdateModel, A2BillingService.Data.Entities.CcCurrencies>();
        }

    }
}
