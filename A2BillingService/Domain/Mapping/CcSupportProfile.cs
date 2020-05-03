using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcSupportProfile
        : AutoMapper.Profile
    {
        public CcSupportProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcSupport, A2BillingService.Domain.Models.CcSupportReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcSupportCreateModel, A2BillingService.Data.Entities.CcSupport>();
            CreateMap<A2BillingService.Data.Entities.CcSupport, A2BillingService.Domain.Models.CcSupportUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcSupportUpdateModel, A2BillingService.Data.Entities.CcSupport>();
        }

    }
}
