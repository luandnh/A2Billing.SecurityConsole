using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSipBuddiesProfile
        : AutoMapper.Profile
    {
        public CcSipBuddiesProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSipBuddies, A2BillingService.Domain.Models.CcSipBuddiesReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSipBuddiesCreateModel, A2BillingService.Data.Entities.CcSipBuddies>();
            CreateMap<A2BillingService.Data.Entities.CcSipBuddies, A2BillingService.Domain.Models.CcSipBuddiesUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSipBuddiesUpdateModel, A2BillingService.Data.Entities.CcSipBuddies>();
        }

    }
}
