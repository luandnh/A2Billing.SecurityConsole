using System;
using AutoMapper;
using A2BillingService.Data.Entities;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Mapping
{
    public partial class CcMonitorProfile
        : AutoMapper.Profile
    {
        public CcMonitorProfile()
        {
            CreateMap<A2BillingService.Data.Entities.CcMonitor, A2BillingService.Domain.Models.CcMonitorReadModel>();
            CreateMap<A2BillingService.Domain.Models.CcMonitorCreateModel, A2BillingService.Data.Entities.CcMonitor>();
            CreateMap<A2BillingService.Data.Entities.CcMonitor, A2BillingService.Domain.Models.CcMonitorUpdateModel>();
            CreateMap<A2BillingService.Domain.Models.CcMonitorUpdateModel, A2BillingService.Data.Entities.CcMonitor>();
        }

    }
}
