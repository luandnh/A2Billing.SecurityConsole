using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcConfigGroupProfile
        : AutoMapper.Profile
    {
        public CcConfigGroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcConfigGroup, A2BillingService.Domain.Models.CcConfigGroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcConfigGroupCreateModel, A2BillingService.Data.Entities.CcConfigGroup>();
            CreateMap<A2BillingService.Data.Entities.CcConfigGroup, A2BillingService.Domain.Models.CcConfigGroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcConfigGroupUpdateModel, A2BillingService.Data.Entities.CcConfigGroup>();
        }

    }
}
