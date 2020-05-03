using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcServerGroupProfile
        : AutoMapper.Profile
    {
        public CcServerGroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcServerGroup, A2BillingService.Domain.Models.CcServerGroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcServerGroupCreateModel, A2BillingService.Data.Entities.CcServerGroup>();
            CreateMap<A2BillingService.Data.Entities.CcServerGroup, A2BillingService.Domain.Models.CcServerGroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcServerGroupUpdateModel, A2BillingService.Data.Entities.CcServerGroup>();
        }

    }
}
