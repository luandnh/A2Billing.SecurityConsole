using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcIaxBuddiesProfile
        : AutoMapper.Profile
    {
        public CcIaxBuddiesProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcIaxBuddies, A2BillingService.Domain.Models.CcIaxBuddiesReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcIaxBuddiesCreateModel, A2BillingService.Data.Entities.CcIaxBuddies>();
            CreateMap<A2BillingService.Data.Entities.CcIaxBuddies, A2BillingService.Domain.Models.CcIaxBuddiesUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcIaxBuddiesUpdateModel, A2BillingService.Data.Entities.CcIaxBuddies>();
        }

    }
}
