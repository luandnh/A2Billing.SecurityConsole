using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPrefixProfile
        : AutoMapper.Profile
    {
        public CcPrefixProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPrefix, A2BillingService.Domain.Models.CcPrefixReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPrefixCreateModel, A2BillingService.Data.Entities.CcPrefix>();
            CreateMap<A2BillingService.Data.Entities.CcPrefix, A2BillingService.Domain.Models.CcPrefixUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPrefixUpdateModel, A2BillingService.Data.Entities.CcPrefix>();
        }

    }
}
