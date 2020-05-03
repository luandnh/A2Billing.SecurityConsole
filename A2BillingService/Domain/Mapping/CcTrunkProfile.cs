using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTrunkProfile
        : AutoMapper.Profile
    {
        public CcTrunkProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTrunk, A2BillingService.Domain.Models.CcTrunkReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTrunkCreateModel, A2BillingService.Data.Entities.CcTrunk>();
            CreateMap<A2BillingService.Data.Entities.CcTrunk, A2BillingService.Domain.Models.CcTrunkUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTrunkUpdateModel, A2BillingService.Data.Entities.CcTrunk>();
        }

    }
}
