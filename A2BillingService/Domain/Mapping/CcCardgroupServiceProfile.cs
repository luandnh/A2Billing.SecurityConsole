using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcCardgroupServiceProfile
        : AutoMapper.Profile
    {
        public CcCardgroupServiceProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcCardgroupService, A2BillingService.Domain.Models.CcCardgroupServiceReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardgroupServiceCreateModel, A2BillingService.Data.Entities.CcCardgroupService>();
            CreateMap<A2BillingService.Data.Entities.CcCardgroupService, A2BillingService.Domain.Models.CcCardgroupServiceUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcCardgroupServiceUpdateModel, A2BillingService.Data.Entities.CcCardgroupService>();
        }

    }
}
