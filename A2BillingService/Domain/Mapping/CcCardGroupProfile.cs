using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardGroupProfile
        : AutoMapper.Profile
    {
        public CcCardGroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardGroup, A2BillingService.Domain.Models.CcCardGroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardGroupCreateModel, A2BillingService.Data.Entities.CcCardGroup>();
            CreateMap<A2BillingService.Data.Entities.CcCardGroup, A2BillingService.Domain.Models.CcCardGroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardGroupUpdateModel, A2BillingService.Data.Entities.CcCardGroup>();
        }

    }
}
