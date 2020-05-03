using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcVersionProfile
        : AutoMapper.Profile
    {
        public CcVersionProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcVersion, A2BillingService.Domain.Models.CcVersionReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcVersionCreateModel, A2BillingService.Data.Entities.CcVersion>();
            CreateMap<A2BillingService.Data.Entities.CcVersion, A2BillingService.Domain.Models.CcVersionUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcVersionUpdateModel, A2BillingService.Data.Entities.CcVersion>();
        }

    }
}
