using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSipBuddiesEmptyProfile
        : AutoMapper.Profile
    {
        public CcSipBuddiesEmptyProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSipBuddiesEmpty, A2BillingService.Domain.Models.CcSipBuddiesEmptyReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSipBuddiesEmptyCreateModel, A2BillingService.Data.Entities.CcSipBuddiesEmpty>();
            CreateMap<A2BillingService.Data.Entities.CcSipBuddiesEmpty, A2BillingService.Domain.Models.CcSipBuddiesEmptyUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSipBuddiesEmptyUpdateModel, A2BillingService.Data.Entities.CcSipBuddiesEmpty>();
        }

    }
}
