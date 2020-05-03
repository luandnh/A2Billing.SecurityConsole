using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPackageRateProfile
        : AutoMapper.Profile
    {
        public CcPackageRateProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPackageRate, A2BillingService.Domain.Models.CcPackageRateReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackageRateCreateModel, A2BillingService.Data.Entities.CcPackageRate>();
            CreateMap<A2BillingService.Data.Entities.CcPackageRate, A2BillingService.Domain.Models.CcPackageRateUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackageRateUpdateModel, A2BillingService.Data.Entities.CcPackageRate>();
        }

    }
}
