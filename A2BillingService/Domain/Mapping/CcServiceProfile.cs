using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcServiceProfile
        : AutoMapper.Profile
    {
        public CcServiceProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcService, A2BillingService.Domain.Models.CcServiceReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcServiceCreateModel, A2BillingService.Data.Entities.CcService>();
            CreateMap<A2BillingService.Data.Entities.CcService, A2BillingService.Domain.Models.CcServiceUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcServiceUpdateModel, A2BillingService.Data.Entities.CcService>();
        }

    }
}
