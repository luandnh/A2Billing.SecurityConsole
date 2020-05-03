using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcPackgroupPackageProfile
        : AutoMapper.Profile
    {
        public CcPackgroupPackageProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcPackgroupPackage, A2BillingService.Domain.Models.CcPackgroupPackageReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackgroupPackageCreateModel, A2BillingService.Data.Entities.CcPackgroupPackage>();
            CreateMap<A2BillingService.Data.Entities.CcPackgroupPackage, A2BillingService.Domain.Models.CcPackgroupPackageUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcPackgroupPackageUpdateModel, A2BillingService.Data.Entities.CcPackgroupPackage>();
        }

    }
}
