using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTariffplanProfile
        : AutoMapper.Profile
    {
        public CcTariffplanProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTariffplan, A2BillingService.Domain.Models.CcTariffplanReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTariffplanCreateModel, A2BillingService.Data.Entities.CcTariffplan>();
            CreateMap<A2BillingService.Data.Entities.CcTariffplan, A2BillingService.Domain.Models.CcTariffplanUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTariffplanUpdateModel, A2BillingService.Data.Entities.CcTariffplan>();
        }

    }
}
