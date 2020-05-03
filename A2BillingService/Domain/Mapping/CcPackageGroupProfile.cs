using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPackageGroupProfile
        : AutoMapper.Profile
    {
        public CcPackageGroupProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPackageGroup, A2BillingService.Domain.Models.CcPackageGroupReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackageGroupCreateModel, A2BillingService.Data.Entities.CcPackageGroup>();
            CreateMap<A2BillingService.Data.Entities.CcPackageGroup, A2BillingService.Domain.Models.CcPackageGroupUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackageGroupUpdateModel, A2BillingService.Data.Entities.CcPackageGroup>();
        }

    }
}
