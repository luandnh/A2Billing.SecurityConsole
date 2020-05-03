using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcChargeProfile
        : AutoMapper.Profile
    {
        public CcChargeProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCharge, A2BillingService.Domain.Models.CcChargeReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcChargeCreateModel, A2BillingService.Data.Entities.CcCharge>();
            CreateMap<A2BillingService.Data.Entities.CcCharge, A2BillingService.Domain.Models.CcChargeUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcChargeUpdateModel, A2BillingService.Data.Entities.CcCharge>();
        }

    }
}
