using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcRatecardProfile
        : AutoMapper.Profile
    {
        public CcRatecardProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcRatecard, A2BillingService.Domain.Models.CcRatecardReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcRatecardCreateModel, A2BillingService.Data.Entities.CcRatecard>();
            CreateMap<A2BillingService.Data.Entities.CcRatecard, A2BillingService.Domain.Models.CcRatecardUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcRatecardUpdateModel, A2BillingService.Data.Entities.CcRatecard>();
        }

    }
}
