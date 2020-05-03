using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcTimezoneProfile
        : AutoMapper.Profile
    {
        public CcTimezoneProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcTimezone, A2BillingService.Domain.Models.CcTimezoneReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcTimezoneCreateModel, A2BillingService.Data.Entities.CcTimezone>();
            CreateMap<A2BillingService.Data.Entities.CcTimezone, A2BillingService.Domain.Models.CcTimezoneUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcTimezoneUpdateModel, A2BillingService.Data.Entities.CcTimezone>();
        }

    }
}
