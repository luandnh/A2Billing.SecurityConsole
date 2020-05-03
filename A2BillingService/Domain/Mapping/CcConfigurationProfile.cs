using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcConfigurationProfile
        : AutoMapper.Profile
    {
        public CcConfigurationProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcConfiguration, A2BillingService.Domain.Models.CcConfigurationReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcConfigurationCreateModel, A2BillingService.Data.Entities.CcConfiguration>();
            CreateMap<A2BillingService.Data.Entities.CcConfiguration, A2BillingService.Domain.Models.CcConfigurationUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcConfigurationUpdateModel, A2BillingService.Data.Entities.CcConfiguration>();
        }

    }
}
