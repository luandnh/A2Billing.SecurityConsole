using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcDidUseProfile
        : AutoMapper.Profile
    {
        public CcDidUseProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcDidUse, A2BillingService.Domain.Models.CcDidUseReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidUseCreateModel, A2BillingService.Data.Entities.CcDidUse>();
            CreateMap<A2BillingService.Data.Entities.CcDidUse, A2BillingService.Domain.Models.CcDidUseUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcDidUseUpdateModel, A2BillingService.Data.Entities.CcDidUse>();
        }

    }
}
